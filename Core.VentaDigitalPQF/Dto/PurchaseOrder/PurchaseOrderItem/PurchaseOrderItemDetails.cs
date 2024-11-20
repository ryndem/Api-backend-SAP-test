using Core.VentaDigitalPQF.Dto.Quotation.QuotationItem;

namespace Core.VentaDigitalPQF.Dto.PurchaseOrder.PurchaseOrderItem
{
    public class PurchaseOrderItemDetails : QuotationItemDetails
    {
        public Guid? IdPurchaseOrder { get; set; }
        public Guid? IdPurchaseOrderItem { get; set; }
    }
}
