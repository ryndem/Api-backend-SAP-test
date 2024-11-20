namespace Logic.VentaDigitalPQF.Interfaces.IdentityServer
{
    public interface IIdentityServerAccessManager
    {
        public Tuple<string, string> ObtenerUserNameYNombre(string Token);
        public string RequestAccessToken(string username, string password);
        public List<string> ObtenerRoles(string AccessToken);
    }
}
