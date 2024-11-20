//using Core.CrudTools.Optimization;
using Proxy.ProquifaDotNet.CrudTools;
using Proxy.ProquifaDotNet.Model;
using Proxy.ProquifaDotNet.Proxy;
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
using Proxy.ProquifaDotNet.Dto;
using Core.VentaDigitalPQF.Dto.Product;
using Core.VentaDigitalPQF.ExceptionHandler;

namespace Proxy.ProquifaDotNet.Services
{
    public class OfertaProductoProxy : IOfertaProductoProxy
    {
        private readonly TokenAsynProquifaDotNet _tokenPQF;
        private readonly ApiProquifaDotNetCatalogoUrl _apiProquifaDotNetCatalogoUrl;
        private IApiCallerProxy _apiCallerProxy;
        public OfertaProductoProxy( IApiCallerProxy apiCallerProxy, TokenAsynProquifaDotNet tokenPQF, ApiProquifaDotNetCatalogoUrl apiProquifaDotNetCatalogoUrl ) {
            //_tokenPQF = new TokenAsynProquifaDotNet();
            _apiCallerProxy = apiCallerProxy;
            _tokenPQF = tokenPQF;
            _apiProquifaDotNetCatalogoUrl = apiProquifaDotNetCatalogoUrl;

        }
        public async Task<PrecioOferta> GetOfertaProducto( ProductoRequest productoRequest )
        {
            return await GetOfertaProducto( productoRequest.IdProducto.GetValueOrDefault(), productoRequest.IdCliente, productoRequest.IdDireccionEntrega , 1 );
        }
        public async Task<PrecioOferta> GetOfertaProducto( ProductoClienteVDRequest productoRequest )
        {
            return await GetOfertaProducto( productoRequest.IdProducto.GetValueOrDefault(), productoRequest.IdCliente, productoRequest.IdDireccionEntrega, 1);
        }

        public async Task<PrecioOferta> GetOfertaProducto( ProductoClienteWebRequest productoRequest )
        {
            return await GetOfertaProducto( productoRequest.IdProducto.GetValueOrDefault(), productoRequest.IdCliente, productoRequest.IdDireccionEntrega, 1);
        }

        public async Task<PrecioOferta> GetOfertaProducto( Guid IdProducto, Guid? IdCliente, Guid? IdDireccionEntrega, int? piezas = 1)
        {
            if(IdCliente == null)
            {
                IdCliente = Guid.Parse("C88FCF28-3C25-4A14-95EB-7C2EDD755894");
            }
            if ( IdDireccionEntrega == null )
            {
                IdDireccionEntrega = Guid.Parse( "E4674B4E-42A3-47F9-93CA-3DEBA4D144D8" );
            }
            if ( piezas == null )
            {
                piezas = 1;
            }

            /*
                * /ContratoCliente/GetConfiguracionProquifaNetClienteContrato?piezas=2&idProducto=5ebd3b04-6256-4abe-8a20-a638c95631ef&idCliente=59656a7d-3a5b-4f9e-9372-3823ef2a6ab7&idCatMoneda=2f4a2aba-938d-46ac-8197-fb4795c64302&IdDireccionEntrega=f3c87af6-73b3-49ec-9039-374a3302b518
                */
            var paramsQuery = new {IdCliente = IdCliente, IdProducto = IdProducto, IdDireccionEntrega = IdDireccionEntrega, piezas = piezas };

            var contenido = await _apiCallerProxy.Post( "ContratoCliente/GetConfiguracionProquifaNetClienteContrato", null, paramsQuery, (int)ProxyApiSelector.Catalogo );
            PrecioOferta oferta = new PrecioOferta();
            try
            {
                oferta = JsonConvert.DeserializeObject<PrecioOferta>( contenido );
                if ( oferta == null )
                {
                    throw new AppException( "Model is null" );
                }
            }

            catch ( Exception ex )
            {
                throw new AppException( ex.Message, ex );
            }
            return oferta;
        }

        
    }
}
