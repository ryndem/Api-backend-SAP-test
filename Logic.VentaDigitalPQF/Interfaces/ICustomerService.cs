//using Core.CrudTools.Optimization;
using Core.VentaDigitalPQF.Dto.Product;

namespace Logic.VentaDigitalPQF.Interfaces
{
    public interface ICustomerService
    {
        Task<ProductDetails> GetCustomer(Guid IdCustomer);
    }
}
