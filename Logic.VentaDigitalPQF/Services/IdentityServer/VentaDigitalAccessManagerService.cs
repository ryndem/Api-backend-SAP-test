using log4net;
using Logic.VentaDigitalPQF.Interfaces.IdentityServer;
using System.Configuration;
using System.Net;

namespace Logic.VentaDigitalPQF.Services.IdentityServer
{
    public class VentaDigitalAccessManagerService : IVentaDigitalAccessManager
    {
        private readonly IIdentityServerAccessManager _identityServerAccessManager;

        public VentaDigitalAccessManagerService(IIdentityServerAccessManager identityServerAccessManager)
        {
            _identityServerAccessManager = identityServerAccessManager;
        }

        public static bool Enabled
        {
            get
            {
                try
                {
                    return !string.IsNullOrEmpty(ConfigurationManager.AppSettings["IdentityServer:Url"]);
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool EsSuperUsuario(string AccessToken)
        {
            throw new NotImplementedException();
        }

        public string ObtenerUserName(string AccessToken)
        {
            try
            {
                //En caso de que ya se encuentre escrito, trae directamente la variable de memoría
                if (!string.IsNullOrEmpty((string)ThreadContext.Properties["username"]))
                    if ((string)ThreadContext.Properties["username"] != "unknown")
                        return (string)ThreadContext.Properties["username"];
            }
            catch
            {
                //Ignore
            }

            return _identityServerAccessManager.ObtenerUserNameYNombre(AccessToken).Item1;
        }

        public bool ValidateToken(string Token, string Sistema, string Scope, string Controlador, string Accion, string Metodo, string ip)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                ServicePointManager.UseNagleAlgorithm = true;
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.CheckCertificateRevocationList = true;
                ServicePointManager.DefaultConnectionLimit = ServicePointManager.DefaultPersistentConnectionLimit;

                ServicePointManager.ServerCertificateValidationCallback +=
                    (sender, certificate, chain, sslPolicyErrors) => true;

                var roles = _identityServerAccessManager.ObtenerRoles(Token);

                //Si no tiene roles, no está en el sistema
                if (!roles.Any())
                    throw new Exception("Acceso no autorizado");

                //if (roles.Contains(Constants.Roles.RolSuperusuario))
                //    return true;

                var userNameYNombre = _identityServerAccessManager.ObtenerUserNameYNombre(Token);


                // Logger.Debug(string.Format(
                //    "Acceso autorizado al controlador {0}, acción {1}, método {2}, por el usuario {3} ({4}), desde la dirección {5}",
                //    Controlador, Accion, Metodo, userNameYNombre.Item2,
                //    userNameYNombre.Item1, ip));

                return true;
            }
            catch (Exception e)
            {
                // Logger.Fatal("Intento de acceso no autorizado");
                throw new Exception("Error al intentar validar el token", e);
            }
        }
    }
}
