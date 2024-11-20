using Core.VentaDigitalPQF.CrudTools;
using Newtonsoft.Json;
using Proxy.ProquifaDotNet.CrudTools;
using Proxy.ProquifaDotNet.Interfaces;
using Proxy.ProquifaDotNet.Model.Direccion;
using Proxy.ProquifaDotNet.Proxy;
using Proxy.ProquifaDotNet.Services.Interfaces.Direccion;

namespace Proxy.ProquifaDotNet.Services.Service
{
    public class DireccionProxy : IDireccionProxy
    {
        private readonly IApiCallerProxy _apiCallerProxy;
        public DireccionProxy(IApiCallerProxy apiCallerProxy)
        {
            _apiCallerProxy = apiCallerProxy;
        }
        public async Task<QueryResultVD<vDireccion>> GetDirecciones(QueryInfoVD Info)
        {
            QueryResultVD<vDireccion> respuesta = new();
            try
            {
                var contenido = await _apiCallerProxy.Post("vDireccion", Info, null, (int)ProxyApiSelector.Catalogo);
                respuesta = JsonConvert.DeserializeObject<QueryResultVD<vDireccion>>(contenido);
            }
            catch (Exception)
            {

            }
            return respuesta;
        }
    }
}
