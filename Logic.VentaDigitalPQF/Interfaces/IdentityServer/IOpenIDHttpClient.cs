using IdentityModel.Client;

namespace Logic.VentaDigitalPQF.Interfaces.IdentityServer
{
    public interface IOpenIDHttpClient
    {
        public Task<UserInfoResponse> ObtenerUserInfoAsync(string AccessToken);

        public Task<TokenResponse> ObtenerTokenResponseAsync(string username, string password);
    }
}
