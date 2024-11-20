using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.PurchaseOrder;

namespace Logic.VentaDigitalPQF.Interfaces.PurchaseOrder
{
    public interface IPurchaseOrderService
    {
        Task<PurchaseOrderDetails> GetPurchaseOrderDetails(Guid IdPurchaseOrder);
        Task<QueryResultVD> GetListPurchaseOrder();
        Task<QueryResultVD> ListPurchaseOrderItemsDetails(QueryInfoVD Info);
    }
}
