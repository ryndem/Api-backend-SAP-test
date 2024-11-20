using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.Order;

namespace Logic.VentaDigitalPQF.Interfaces.Order
{
    public interface IOrderService
    {
        Task<QueryResultVD> GetListOrder();
        Task<OrderDetails> GetOrderDetails(Guid IdOrder);
        Task<QueryResultVD> ListOrderItemsDetails(QueryInfoVD Info);
    }
}
