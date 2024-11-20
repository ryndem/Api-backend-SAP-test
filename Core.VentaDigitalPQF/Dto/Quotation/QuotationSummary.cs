using Core.VentaDigitalPQF.Dto.General;

namespace Core.VentaDigitalPQF.Dto.Quotation
{
    public class QuotationSummary : Summary
    {
        public Guid IdQuotation { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool Active { get; set; }
    }
}
