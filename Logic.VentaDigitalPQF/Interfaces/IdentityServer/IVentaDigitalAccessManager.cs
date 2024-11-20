namespace Logic.VentaDigitalPQF.Interfaces.IdentityServer
{
    public interface IVentaDigitalAccessManager
    {
        public string ObtenerUserName(string AccessToken);
        public bool ValidateToken(string Token, string Sistema, string Scope, string Controlador, string Accion, string Metodo, string ip);

        public bool EsSuperUsuario(string AccessToken);
    }
}
