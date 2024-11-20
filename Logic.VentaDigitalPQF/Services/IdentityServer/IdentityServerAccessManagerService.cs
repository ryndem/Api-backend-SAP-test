using Core.VentaDigitalPQF.IdentityServer4.Http;
using Core.VentaDigitalPQF.IdentityServer4.Utils;
using IdentityModel.Client;
using Logic.VentaDigitalPQF.Interfaces.IdentityServer;
using System.Security.Claims;

namespace Logic.VentaDigitalPQF.Services.IdentityServer
{
    public class IdentityServerAccessManagerService : IIdentityServerAccessManager
    {
        private readonly string _AllowedScopes;
        private readonly string _ClientId;
        private readonly string _GrantType;
        private readonly string _IdentityUrl;

        public IdentityServerAccessManagerService(string clientId, string grantType, string allowedScopes, string identityUrl)
        {
            _ClientId = clientId;
            _GrantType = grantType;
            _AllowedScopes = allowedScopes;
            _IdentityUrl = identityUrl;
        }

        public List<string> ObtenerRoles(string AccessToken)
        {
            try
            {
                var claims = ObtenerClaims(AccessToken);
                return claims.Where(x => x.Type == AccessConstants.Claims.ClaimRole).Select(claim => claim.Value)
                    .ToList();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener los roles", e);
            }
        }

        public Tuple<string, string> ObtenerUserNameYNombre(string Token)
        {
            try
            {
                var resultado = ObtenerClaims(Token);
                var nombre = resultado.Single(x => x.Type == AccessConstants.Claims.ClaimName).Value;
                var username = resultado.Single(x => x.Type == AccessConstants.Claims.ClaimUserName).Value;

                return new Tuple<string, string>(username, nombre);
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar validar el token", e);
            }
        }

        public string RequestAccessToken(string username, string password)
        {
            try
            {
                using (var httpClient = new OpenIDHttpClient(_ClientId, _GrantType, _AllowedScopes, _IdentityUrl))
                {
                    var tokenResponse = httpClient.ObtenerTokenResponseAsync(username, password).Result;
                    if (tokenResponse == null)
                        throw new Exception("Error al intentar conectarse con el EndPoint de " + _IdentityUrl);

                    return tokenResponse.AccessToken;
                }
            }

            catch (Exception e)
            {
                throw new Exception("Error al obtener el Token", e);
            }
        }

        private List<Claim> ObtenerClaims(string AccessToken)
        {
            try
            {
                var userInfo = ObtenerUserInfo(AccessToken);
                return userInfo.Claims.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener los Claims", e);
            }
        }

        private UserInfoResponse ObtenerUserInfo(string AccessToken)
        {
            try
            {
                using (var httpClient = new OpenIDHttpClient(_ClientId, _GrantType, _AllowedScopes, _IdentityUrl))
                {
                    return httpClient.ObtenerUserInfoAsync(AccessToken).Result;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el userinfo", e);
            }
        }

    }
}
