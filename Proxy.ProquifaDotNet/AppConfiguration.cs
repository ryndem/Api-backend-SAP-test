using Microsoft.Extensions.Configuration;

namespace Proxy.ProquifaDotNet
{
    public class AppConfiguration 
    {
        private readonly string _sqlConnection;
        private readonly string _identityServerUrl;
        private readonly string _identityServerScope;
        private readonly string _identityServerClientAllowedScopes;
        private readonly string _identityServerGrantType;
        private readonly string _identityServerCliendId;

        public AppConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            //configurationBuilder.AddJson(path, false);

            var root = configurationBuilder.Build();
            _sqlConnection = root.GetConnectionString("DataConnection");

            var appSetting = root.GetSection("ApplicationSettings");
            _identityServerUrl = appSetting["IdentityServerUrl"];
            _identityServerScope = appSetting["IdentityServerScope"];
            _identityServerClientAllowedScopes = appSetting["IdentityServerClientAllowedScopes"];
            _identityServerGrantType = appSetting["IdentityServerGrantType"];
            _identityServerCliendId = appSetting["IdentityServerCliendId"];
        }

        public string SqlDataConnection { get => _sqlConnection; }
        public string IdentityServerUrl { get => _identityServerUrl; }
        public string IdentityServerScope { get => _identityServerScope; }
        public string IdentityServerClientAllowedScopes { get => _identityServerClientAllowedScopes; }
        public string IdentityServerGrantType { get => _identityServerGrantType; }
        public string IdentityServerCliendId { get => _identityServerCliendId; }

    }
}