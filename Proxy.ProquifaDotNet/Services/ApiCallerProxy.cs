//using Core.CrudTools.Optimization;
using Proxy.ProquifaDotNet.CrudTools;
using Proxy.ProquifaDotNet.Model;
using Proxy.ProquifaDotNet.Proxy;
//using IdentityModel.Client;
using Proxy.ProquifaDotNet.Interfaces;
using Newtonsoft.Json;
//using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
//using static System.Runtime.InteropServices.JavaScript.JSType;
using Proxy.ProquifaDotNet.Dto;
using System.Web;
using Core.VentaDigitalPQF.ExceptionHandler;

namespace Proxy.ProquifaDotNet.Services
{
    public class ApiCallerProxy : IApiCallerProxy
    {
        private readonly TokenAsynProquifaDotNet _tokenPQF;
        private readonly ApiProquifaDotNetCatalogoUrl _apiProquifaDotNetCatalogoUrl;
        private readonly ApiProquifaDotNetLogisticaUrl _apiProquifaDotNetLogisticaUrl;
        private HttpClient _httpClient;
        private bool ApiCatalogo = true;
        private bool ApiLogistica = false;
        public ApiCallerProxy( HttpClient httpClient, TokenAsynProquifaDotNet tokenPQF, ApiProquifaDotNetCatalogoUrl apiProquifaDotNetCatalogoUrl, ApiProquifaDotNetLogisticaUrl apiProquifaDotNetLogisticaUrl )
        {
            //_tokenPQF = new TokenAsynProquifaDotNet();
            _httpClient = httpClient;
            _tokenPQF = tokenPQF;
            _apiProquifaDotNetCatalogoUrl = apiProquifaDotNetCatalogoUrl;
            _apiProquifaDotNetLogisticaUrl = apiProquifaDotNetLogisticaUrl;
        }
        private string UrlApi( int ApiSelector )
        {
            if( ApiSelector == (int)ProxyApiSelector.Catalogo )
            {
                return _apiProquifaDotNetCatalogoUrl.Value;
            }
            else if ( ApiSelector == (int)ProxyApiSelector.Logistica )
            {
                return _apiProquifaDotNetLogisticaUrl.Value;
            }
            else
            {
                throw new ProxyException( "Proxy URL Not Selected" );
            }
        }

        public async Task<string> Get( string Controller, string CampoLlave, Guid IdGuid, int ApiSelector = (int)ProxyApiSelector.Catalogo )
        {
            _httpClient = await _tokenPQF.SincronizaToken();
            var contenido = "";
            try
            {
                string url = $"{this.UrlApi( ApiSelector )}/{Controller}?{CampoLlave}={IdGuid}";
                var request = await _httpClient.GetAsync( url );
                if ( request.IsSuccessStatusCode )
                {
                    request.EnsureSuccessStatusCode();
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.NotFound )
                {
                    throw new ProxyException( "Route not found in proxy" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.Unauthorized )
                {
                    throw new ProxyException( "Unauthorized proxy" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.GatewayTimeout )
                {
                    throw new ProxyException( "Proxy TimeOut" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.InternalServerError )
                {
                    throw new ProxyException( "Proxy Internal Server Error" );
                }
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };
                contenido = await request.Content.ReadAsStringAsync();
                //return JsonConvert.DeserializeObject<object>( contenido );
            }
            catch ( Exception ex )
            {
                throw new ProxyException( ex.Message, ex );
            }
            return contenido;
        }

        public async Task<string> Get( string Controller, object? GetParametros, int ApiSelector = (int)ProxyApiSelector.Catalogo )
        {
            _httpClient = await _tokenPQF.SincronizaToken();
            var contenido = "";
            try
            {
                string QString = "";
                if ( GetParametros != null )
                {
                    QString = "?" + QueryString( GetParametros );
                }
                string url = $"{this.UrlApi( ApiSelector )}/{Controller}{QString}";
                var request = await _httpClient.GetAsync( url );
                if ( request.IsSuccessStatusCode )
                {
                    request.EnsureSuccessStatusCode();
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.NotFound )
                {
                    throw new ProxyException( "Route not found in proxy" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.Unauthorized )
                {
                    throw new ProxyException( "Unauthorized proxy" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.GatewayTimeout )
                {
                    throw new ProxyException( "Proxy TimeOut" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.InternalServerError )
                {
                    throw new ProxyException( "Proxy Internal Server Error" );
                }
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };
                contenido = await request.Content.ReadAsStringAsync();
                //return JsonConvert.DeserializeObject<object>( contenido );
            }
            catch ( Exception ex )
            {
                throw new ProxyException( ex.Message, ex );
            }
            return contenido;
        }
        public async Task<string> Post( string Controller, object? info, object? GetParametros, int ApiSelector = (int)ProxyApiSelector.Catalogo )
        {
            _httpClient = await _tokenPQF.SincronizaToken();
            var content = new StringContent(
                System.Text.Json.JsonSerializer.Serialize( info ),
                System.Text.Encoding.UTF8,
                "application/json"
            );
            var contenido = "";
            try
            {
                string QString = "";
                if ( GetParametros != null )
                {
                    QString = "?" + QueryString( GetParametros );
                }
                string url = $"{this.UrlApi( ApiSelector )}/{Controller}{QString}";
                var request = await _httpClient.PostAsync( url, content );
                if ( request.IsSuccessStatusCode )
                {
                    request.EnsureSuccessStatusCode();
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.NotFound )
                {
                    throw new ProxyException( "Route not found in proxy" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.Unauthorized )
                {
                    throw new ProxyException( "Unauthorized proxy" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.GatewayTimeout )
                {
                    throw new ProxyException( "Proxy TimeOut" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.InternalServerError )
                {
                    throw new ProxyException( "Proxy Internal Server Error" );
                }
                var options = new JsonSerializerOptions
                {
                    // PropertyNameCaseInsensitive = true,
                };
                contenido = await request.Content.ReadAsStringAsync();
            }
            catch ( Exception ex )
            {
                throw new ProxyException( ex.Message, ex );
            }
            return contenido;
        }
        public async Task<string> Put( string Controller, object? FromBody, object? GetParametros, int ApiSelector = (int)ProxyApiSelector.Catalogo )
        {
            _httpClient = await _tokenPQF.SincronizaToken();
            var content = new StringContent(
                System.Text.Json.JsonSerializer.Serialize( FromBody ),
                System.Text.Encoding.UTF8,
                "application/json"
            );
            var contenido = "";
            try
            {
                string QString = "";
                if ( GetParametros != null )
                {
                    QString = "?" + QueryString( GetParametros );
                }
                string url = $"{this.UrlApi( ApiSelector )}/{Controller}{QString}";
                var request = await _httpClient.PutAsync( url, content );
                if ( request.IsSuccessStatusCode )
                {
                    request.EnsureSuccessStatusCode();
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.NotFound )
                {
                    throw new ProxyException( "Route not found in proxy" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.Unauthorized )
                {
                    throw new ProxyException( "Unauthorized proxy" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.GatewayTimeout )
                {
                    throw new ProxyException( "Proxy TimeOut" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.InternalServerError )
                {
                    throw new ProxyException( "Proxy Internal Server Error" );
                }
                var options = new JsonSerializerOptions
                {
                    // PropertyNameCaseInsensitive = true,
                };
                contenido = await request.Content.ReadAsStringAsync();

            }
            catch ( Exception ex )
            {
                throw new ProxyException( ex.Message, ex );
            }
            return contenido;
        }
        public async Task<string> Patch( string Controller, object? FromBody, object? GetParametros, int ApiSelector = (int)ProxyApiSelector.Catalogo )
        {
            _httpClient = await _tokenPQF.SincronizaToken();
            var content = new StringContent(
                System.Text.Json.JsonSerializer.Serialize( FromBody ),
                System.Text.Encoding.UTF8,
                "application/json"
            );
            var contenido = "";
            try
            {
                string QString = "";
                if ( GetParametros != null )
                {
                    QString = "?" + QueryString( GetParametros );
                }
                string url = $"{this.UrlApi( ApiSelector )}/{Controller}{QString}";
                var request = await _httpClient.PatchAsync( url, content );
                if ( request.IsSuccessStatusCode )
                {
                    request.EnsureSuccessStatusCode();
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.NotFound )
                {
                    throw new ProxyException( "Route not found in proxy" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.Unauthorized )
                {
                    throw new ProxyException( "Unauthorized proxy" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.GatewayTimeout )
                {
                    throw new ProxyException( "Proxy TimeOut" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.InternalServerError )
                {
                    throw new ProxyException( "Proxy Internal Server Error" );
                }
                var options = new JsonSerializerOptions
                {
                    // PropertyNameCaseInsensitive = true,
                };
                contenido = await request.Content.ReadAsStringAsync();

            }
            catch ( Exception ex )
            {
                throw new ProxyException( ex.Message, ex );
            }
            return contenido;
        }
        public async Task<string> Delete( string Controller, string CampoLlave, Guid IdGuid, int ApiSelector = (int)ProxyApiSelector.Catalogo )
        {
            _httpClient = await _tokenPQF.SincronizaToken();
            var contenido = "";
            try
            {
                string url = $"{this.UrlApi( ApiSelector )}/{Controller}?{CampoLlave}={IdGuid}";
                var request = await _httpClient.DeleteAsync( url );
                if ( request.IsSuccessStatusCode )
                {
                    request.EnsureSuccessStatusCode();
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.NotFound )
                {
                    throw new ProxyException( "Route not found in proxy" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.Unauthorized )
                {
                    throw new ProxyException( "Unauthorized proxy" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.GatewayTimeout )
                {
                    throw new ProxyException( "Proxy TimeOut" );
                }
                else if ( request.StatusCode == System.Net.HttpStatusCode.InternalServerError )
                {
                    throw new ProxyException( "Proxy Internal Server Error" );
                }
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };
                contenido = await request.Content.ReadAsStringAsync();
                //return JsonConvert.DeserializeObject<object>( contenido );
            }
            catch ( Exception ex )
            {
                throw new ProxyException( ex.Message, ex );
            }
            return contenido;
        }
        private string QueryString( object obj )
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue( obj, null ) != null
                             select p.Name + "=" + HttpUtility.UrlEncode( p.GetValue( obj, null ).ToString() );

            return string.Join( "&", properties.ToArray() );
        }
    }
}
