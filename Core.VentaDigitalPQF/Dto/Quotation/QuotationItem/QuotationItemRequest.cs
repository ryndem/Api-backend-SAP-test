namespace Core.VentaDigitalPQF.Dto.Quotation.QuotationItem
{
    public class QuotationItemRequest
    {
        public Guid IdQuotationItem { get; set; }
        public Guid ProductOfferId { get; set; }
        public int Quantity { get; set; }
        public bool AppliesFreightExpress { get; set; }
    }
}
