namespace Core.VentaDigitalPQF.Dto.Quotation.QuotationItem
{
    public class QuotationItemSCarRequest
    {
        public Guid? IdQuotation { get; set; }
        public Guid? IdQuotationItem { get; set; }
        public Guid? ProductId { get; set; }
        public int? Quantity { get; set; }
    }
}