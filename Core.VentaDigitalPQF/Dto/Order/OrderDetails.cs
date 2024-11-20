using Core.VentaDigitalPQF.Dto.PurchaseOrder;

namespace Core.VentaDigitalPQF.Dto.Order
{
    public class OrderDetails : PurchaseOrderDetails
    {
        public Guid IdOrder { get; set; }
        public Guid IdOrderFile { get; set; }
        public string? Status { get; set; }

    }
}
