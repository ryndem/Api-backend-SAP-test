using Newtonsoft.Json;
using System.Net.Security;
using System.Security.Authentication;
using System.Text.Json;

namespace Proxy.ProquifaDotNet.Proxy
{
    public class TokenAsynProquifaDotNet
    {
        private ResponseNewToken token { get; set; }
        private readonly HttpClient _httpClient;

        public TokenAsynProquifaDotNet()//IConfigurationRoot configuration
        {
            //configuration.
            _httpClient = new HttpClient();
            token = new ResponseNewToken();
        }
        public async Task<HttpClient> SincronizaToken()
        {
            //_requestNewToken = new RequestNewToken( _configuration );
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ClientCertificateOptions = ClientCertificateOption.Automatic;
            clientHandler.SslProtocols = SslProtocols.Tls12;//SslProtocols.Tls12;
            clientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
            {
                Console.WriteLine($"Requested URI: {message.RequestUri}");
                Console.WriteLine($"Effective date: {cert?.GetEffectiveDateString()}");
                Console.WriteLine($"Exp date: {cert?.GetExpirationDateString()}");
                Console.WriteLine($"Issuer: {cert?.Issuer}");
                Console.WriteLine($"Subject: {cert?.Subject}");

                // Based on the custom logic it is possible to decide whether the client considers certificate valid or not
                Console.WriteLine($"Errors: {sslPolicyErrors}");

                if (sslPolicyErrors == SslPolicyErrors.None)
                {
                    return true;   //Is valid
                }
                return true;
            };

            var client = new HttpClient(clientHandler);
            var request = new HttpRequestMessage(HttpMethod.Post, "https://172.24.32.36:9002/connect/token" );
            var collection = new List<KeyValuePair<string, string>>();
            collection.Add(new("grant_type", "password"));
            collection.Add(new("client_id", "ro.client"));
            collection.Add(new("password", "AABBcc22++"));
            collection.Add(new("scope", "openid profile roles offline_access default"));
            collection.Add(new("username", "Super"));
            var content = new FormUrlEncodedContent(collection);
            request.Content = content;
            var response = await client.SendAsync(request);
            //response.EnsureSuccessStatusCode();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            var contenido = await response.Content.ReadAsStringAsync();
            token = JsonConvert.DeserializeObject<ResponseNewToken>(contenido);
            /*if( token == null )
            {
                token = new ResponseNewToken();
            }*/
            HttpClient httpClient = new HttpClient(clientHandler);
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.access_token);
            //return token.access_token;
            return httpClient;
        }
        public string toString()
        {
            return token.access_token;
        }
    }
}
