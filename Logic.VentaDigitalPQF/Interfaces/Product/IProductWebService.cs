//using Core.CrudTools.Optimization;
using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.Product;
using Core.VentaDigitalPQF.Dto.ProductCustomerWeb;
using Proxy.ProquifaDotNet.CrudTools;
using Proxy.ProquifaDotNet.Model;

namespace Logic.VentaDigitalPQF.Interfaces.Product
{
    public interface IProductWebService
    {
        Task<ProductCustomerWebDetails> GetProductWeb( ProductCustomerWebRequest productoRequest );
        Task<ProductCustomerWebDetails> GetDetails( ProductCustomerWebRequest productoRequest );
        Task<QueryResultVD> GetProducts( QueryInfoVD info, ProductCustomerWebRequest productRequest );
    }
}
