//using Core.CrudTools.Optimization;
using Proxy.ProquifaDotNet.CrudTools;
using Proxy.ProquifaDotNet.Model;
using Logic.VentaDigitalPQF.Services;
using Core.VentaDigitalPQF.Dto.Product;
using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.ProductCustomer;

namespace Logic.VentaDigitalPQF.Interfaces.Product
{
    public interface IProductCustomerService
    {
        Task<ProductCustomerDetails> GetDetails(ProductCustomerRequest productCustomerRequest);
        Task<QueryResultVD> GetProducts( QueryInfoVD info, ProductCustomerRequest productCustomerRequest);
    }
}
