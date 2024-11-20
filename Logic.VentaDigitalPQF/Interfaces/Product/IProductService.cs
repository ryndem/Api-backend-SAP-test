//using Core.CrudTools.Optimization;
using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.Product;

namespace Logic.VentaDigitalPQF.Interfaces.Product
{
    public interface IProductService
    {
        Task<ProductDetails> GetProduct(ProductRequest productoRequest);
        Task<ProductDetails> GetDetails(ProductRequest productoRequest);
        Task<QueryResultVD> GetProducts(object info, ProductRequest productRequest);
    }
}
