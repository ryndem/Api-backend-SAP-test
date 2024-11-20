using Core.VentaDigitalPQF.Dto.Quotation.QuotationItem;

namespace Core.VentaDigitalPQF.Dto.Quotation
{
    public class QuotationSentDetails
    {
        public QuotationDetails? QuotationDetails { get; set; }
        public List<QuotationItemDetails>? ListQuotationItem { get; set; }
    }
}
