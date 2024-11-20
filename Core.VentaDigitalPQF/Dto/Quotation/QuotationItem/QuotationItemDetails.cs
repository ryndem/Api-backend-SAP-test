using Core.VentaDigitalPQF.Dto.General;

namespace Core.VentaDigitalPQF.Dto.Quotation.QuotationItem
{
    public class QuotationItemDetails : Item
    {
        public Guid IdQuotation { get; set; }
        public Guid IdQuotationItem { get; set; }
    }
}
