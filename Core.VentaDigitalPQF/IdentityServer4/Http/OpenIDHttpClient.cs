using IdentityModel.Client;
using System.Net;

namespace Core.VentaDigitalPQF.IdentityServer4.Http
{
    public class OpenIDHttpClient : HttpClient
    {
        private readonly string AllowedScopes;
        private readonly string ClientId;
        private readonly DiscoveryResponse discoveryResponse;
        private readonly string GrantType;
        public OpenIDHttpClient(string clientId, string grantType, string allowedScopes, string identityUrl)
        {
            try
            {
                ClientId = clientId;
                GrantType = grantType;
                AllowedScopes = allowedScopes;
                var authorityUrl = identityUrl;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback +=
                    (sender, certificate, chain, sslPolicyErrors) => true;

#pragma warning disable 618
                var discoveryClient = new DiscoveryClient(authorityUrl);
#pragma warning restore 618
                discoveryClient.Policy.RequireHttps = identityUrl.Contains("https");

                discoveryResponse = discoveryClient.GetAsync().Result;
                if (discoveryResponse.IsError) throw new Exception(discoveryResponse.Error);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener documento discovery", e);
            }
        }

#pragma warning disable 1998
        public async Task<UserInfoResponse> ObtenerUserInfoAsync(string AccessToken)
#pragma warning restore 1998
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;

            var address = discoveryResponse.UserInfoEndpoint;

            return this.GetUserInfoAsync(new UserInfoRequest
            {
                Address = address,
                Token = AccessToken
            }).Result;
        }


#pragma warning disable 1998
        public async Task<TokenResponse> ObtenerTokenResponseAsync(string username, string password)
#pragma warning restore 1998
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback +=
                    (sender, certificate, chain, sslPolicyErrors) => true;

                var clientId = ClientId;
                var scopes = AllowedScopes;
                var grantType = GrantType;
                var address = discoveryResponse.TokenEndpoint;

                return this.RequestPasswordTokenAsync(new PasswordTokenRequest
                {
                    Address = address,
                    ClientId = clientId,
                    Scope = scopes,
                    GrantType = grantType,
                    UserName = username,
                    Password = password
                }).Result;
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar generar el token response", e);
            }
        }
    }
}
