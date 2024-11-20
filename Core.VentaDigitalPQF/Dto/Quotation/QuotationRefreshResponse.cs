using Core.VentaDigitalPQF.Dto.Freight;
using Core.VentaDigitalPQF.Dto.Quotation.QuotationItem;

namespace Core.VentaDigitalPQF.Dto.Quotation
{
    public class QuotationRefreshResponse
    {
        public Guid IdQuotation { get; set; }
        public decimal SaleTax { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public List<QuotationItemRefreshResponse>? listquotationItemRefreshResponses { get; set; }
        public FreightExpressDetails? FreightExpressDetails { get; set; }
        public FreightOutsiderDetails? FreightOutsiderDetails { get; set; }
    }
}
