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
using Proxy.ProquifaDotNet.Dto;
using Core.VentaDigitalPQF.ExceptionHandler;

namespace Proxy.ProquifaDotNet.Services
{
    public class ProductoProxy : IProductoProxy
    {
        private readonly IOfertaProductoProxy _ofertaProductoProxy;
        private readonly IApiCallerProxy _apiCallerProxy;

        public ProductoProxy( IOfertaProductoProxy ofertaProductoProxy, IApiCallerProxy apiCallerProxy ) {
            //_tokenPQF = new TokenAsynProquifaDotNet();
            _ofertaProductoProxy = ofertaProductoProxy;
            _apiCallerProxy = apiCallerProxy;


        }
        public async Task<vProducto> GetProducto( ProductoRequest productoRequest )
        {

            var contenido = await _apiCallerProxy.Get( "vProducto", "IdProducto", productoRequest.IdProducto.GetValueOrDefault(), (int)ProxyApiSelector.Catalogo);
            vProducto producto = new vProducto();
            try
            {
                producto = JsonConvert.DeserializeObject<vProducto>( contenido );
                producto.oferta = await _ofertaProductoProxy.GetOfertaProducto( productoRequest );
            } 
            catch ( Exception ex )
            {
                throw new AppException( "GetProducto Error converting model vProducto", ex );
            }
            return producto;
        }
        public async Task<QueryResultVD<vProducto>> GetProductos( Object info, ProductoRequest productoRequest )
        {
            QueryResultVD<vProducto> respuesta = new QueryResultVD<vProducto>();
            var contenido = await _apiCallerProxy.Post( "vProducto", info, null, (int)ProxyApiSelector.Catalogo);
            try
            {
                respuesta = JsonConvert.DeserializeObject<QueryResultVD<vProducto>>( contenido );
                foreach ( var item in respuesta.Results )
                {
                    productoRequest.IdProducto = item.IdProducto;
                    item.oferta = await _ofertaProductoProxy.GetOfertaProducto( productoRequest );
                }
            }
            catch ( Exception ex )
            {
                throw new AppException( "GetProductos Error converting model vProducto", ex );
            }
            return respuesta;
        }
        #region Obtiene productos para un cliente de Venta Digital Logueado
            public async Task<vProductoClienteVD> GetProductoCliente( ProductoClienteVDRequest productoRequest )
            {
            //FilterTuplePQF filterTuplePQF = new FilterTuplePQF();
                var contenido = await _apiCallerProxy.Get( "vProductoClienteVD", new {IdCliente = productoRequest.IdCliente, idProducto = productoRequest.IdProducto } , (int)ProxyApiSelector.Catalogo );
                vProductoClienteVD producto = new vProductoClienteVD();
                try
                {
                    producto = JsonConvert.DeserializeObject<vProductoClienteVD>( contenido );
                    if(producto == null)
                    {
                        throw new AppException( "Model is null");
                    }
                    producto.oferta = await _ofertaProductoProxy.GetOfertaProducto( productoRequest );
                }
                catch ( Exception ex )
                {
                    throw new AppException( ex.Message, ex );
                }
                return producto;
            }
            public async Task<QueryResultVD<vProductoClienteVD>> GetProductosCliente( QueryInfoPQF queryInfoPQF, ProductoClienteVDRequest productoRequest )
            {
                var ParamsQuery = new {
                    IdCliente = ""+productoRequest.IdCliente
                };

                var contenido = await _apiCallerProxy.Post( "vProductoClienteVDByCliente", queryInfoPQF, ParamsQuery, (int)ProxyApiSelector.Catalogo );
                QueryResultVD<vProductoClienteVD> productos = new QueryResultVD<vProductoClienteVD>();
                try
                {
                    productos = JsonConvert.DeserializeObject<QueryResultVD<vProductoClienteVD>>( contenido );
                    if ( productos == null )
                    {
                        throw new AppException( "Model is null" );
                    }
                    foreach ( var item in productos.Results )
                    {
                        productoRequest.IdProducto = item.IdProducto;
                        item.oferta = await _ofertaProductoProxy.GetOfertaProducto( productoRequest );
                    }
                }
                
                catch ( Exception ex )
                {
                    throw new AppException( ex.Message, ex );
                }
                return productos;
            }
        #endregion
        #region Obtiene productos para un cliente No Logueado de Venta Digital
        public async Task<vProductoClienteWeb> GetProductoClienteWeb( ProductoClienteWebRequest productoRequest )
        {
            //FilterTuplePQF filterTuplePQF = new FilterTuplePQF();

            QueryInfoPQF queryInfoPQF = new QueryInfoPQF { DesiredPage = 1, PageSize = 1 };
            //queryInfoPQF.Filters = new List<FilterTuplePQF>();
            queryInfoPQF.Filters.Add( new FilterTuplePQF( "IdProducto", "" + productoRequest.IdProducto ) );
            queryInfoPQF.Filters.Add( new FilterTuplePQF( "IdCliente", "" + productoRequest.IdCliente ) );
            queryInfoPQF.Filters.Add( new FilterTuplePQF( "IdDireccionEntrega", "" + productoRequest.IdDireccionEntrega ) );

            var contenido = await _apiCallerProxy.Post( "vProductoClienteVD", queryInfoPQF, null, (int)ProxyApiSelector.Catalogo );
            vProductoClienteWeb producto = new vProductoClienteWeb();
            try
            {
                producto = JsonConvert.DeserializeObject<vProductoClienteWeb>( contenido );
                producto.oferta = await _ofertaProductoProxy.GetOfertaProducto( productoRequest );
            }
            catch ( Exception ex )
            {
                throw new AppException( "GetProductos Error converting model vProductoClienteWeb", ex );
            }
            return producto;
        }
        public async Task<QueryResultVD<vProductoClienteWeb>> GetProductosClienteWeb( QueryInfoPQF queryInfoPQF, ProductoClienteWebRequest productoRequest )
        {
            var ParamsQuery = new
            {
                IdCliente = "" + productoRequest.IdCliente
            };

            var contenido = await _apiCallerProxy.Post( "vProductoClienteVDByCliente", queryInfoPQF, ParamsQuery, (int)ProxyApiSelector.Catalogo );
            QueryResultVD<vProductoClienteWeb> productos = new QueryResultVD<vProductoClienteWeb>();
            try
            {
                productos = JsonConvert.DeserializeObject<QueryResultVD<vProductoClienteWeb>>( contenido );

                foreach ( var item in productos.Results )
                {
                    productoRequest.IdProducto = item.IdProducto;
                    item.oferta = await _ofertaProductoProxy.GetOfertaProducto( productoRequest );
                }
            }
            catch ( Exception ex )
            {

            }
            return productos;
        }
        #endregion

    }
}
