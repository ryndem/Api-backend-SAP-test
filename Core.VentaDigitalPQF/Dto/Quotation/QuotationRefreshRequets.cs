using Core.VentaDigitalPQF.Dto.Quotation.QuotationItem;

namespace Core.VentaDigitalPQF.Dto.Quotation
{
    public class QuotationRefreshRequets
    {
        public Guid IdQuotation { get; set; }
        public Guid? AddressId { get; set; } 
        public bool Refresh { get; set; }
        public List<QuotationItemRequest>? ListQuotationItem {  get; set; }
    }
}
