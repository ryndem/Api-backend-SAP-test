using Core.VentaDigitalPQF.Dto.Freight;
using Core.VentaDigitalPQF.Dto.Quotation.QuotationItem;

namespace Core.VentaDigitalPQF.Dto.Quotation
{
    public class QuotationSendResponse
    {
        public QuotationDetails? QuotationDetails { get; set; }
        public List<QuotationItemDetails>? ListQuotationItem {  get; set; }
        public FreightExpressDetails? FreightExpressDetails { get; set; }
        public FreightOutsiderDetails? FreightOutsiderDetails { get; set; }
    }
}
