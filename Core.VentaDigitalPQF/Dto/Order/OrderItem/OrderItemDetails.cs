using Core.VentaDigitalPQF.Dto.PurchaseOrder.PurchaseOrderItem;

namespace Core.VentaDigitalPQF.Dto.Order.OrderItem
{
    public class OrderItemDetails : PurchaseOrderItemDetails
    {
        public Guid IdOrder { get; set; }
        public Guid IdOrderItem { get; set; }
        public ItemDeliveryStatusDetails? DeliveryStatusDetails { get; set; }
    }
}
