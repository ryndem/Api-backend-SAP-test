using Core.VentaDigitalPQF.Dto.Freight;
using Core.VentaDigitalPQF.Dto.Quotation;

namespace Core.VentaDigitalPQF.Dto.PurchaseOrder
{
    public class PurchaseOrderDetails
    {
        public Guid IdPurchaseOrder { get; set; }
        public string? Folio { get; set; }
        public string? Address { get; set; }
        public Guid IdPurchaseOrderFile { get; set; }
        public int Subtotal { get; set; }
        public decimal SaleTax { get; set; }
        public int Total { get; set; }
        public DateTime RegistrationDate { get; set; }
        public List<QuotationSummary>? ListQuotation { get; set; }
        public FreightExpressDetails? FreightExpressDetails { get; set; }
        public FreightOutsiderDetails? FreightOutsiderDetails { get; set; }
    }
}
