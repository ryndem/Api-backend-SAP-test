//using Core.CrudTools.Optimization;
using Proxy.ProquifaDotNet.CrudTools;
using Proxy.ProquifaDotNet.Model;
using Proxy.ProquifaDotNet.Dto;

namespace Proxy.ProquifaDotNet.Interfaces
{
    public interface IProductoProxy
    {
        Task<vProducto> GetProducto(ProductoRequest productoRequest);
        Task<QueryResultVD<vProducto>> GetProductos(Object info, ProductoRequest productoRequest);
        Task<vProductoClienteVD> GetProductoCliente( ProductoClienteVDRequest productoRequest );
        Task<QueryResultVD<vProductoClienteVD>> GetProductosCliente( QueryInfoPQF queryInfoPQF, ProductoClienteVDRequest productoRequest );
        Task<vProductoClienteWeb> GetProductoClienteWeb( ProductoClienteWebRequest productoRequest );
        Task<QueryResultVD<vProductoClienteWeb>> GetProductosClienteWeb( QueryInfoPQF queryInfoPQF, ProductoClienteWebRequest productoRequest );
    }
}
