using Core.VentaDigitalPQF.Dto.PurchaseOrder.PurchaseOrderItem;

namespace Core.VentaDigitalPQF.Dto.PurchaseOrder
{
    public class PurchaseOrderRequest
    {
        public string? PurchaseOrder { get; set; }
        public Guid? FileId { get; set; }
        public bool? Refresh { get; set; }
        public List<ItemToPurchaseOrder>? ItemsToPurchaseOrder { get; set; }
    }
}
