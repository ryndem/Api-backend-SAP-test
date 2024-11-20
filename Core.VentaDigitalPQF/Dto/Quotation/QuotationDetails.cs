namespace Core.VentaDigitalPQF.Dto.Quotation
{
    public class QuotationDetails
    {
        public Guid IdQuotation { get; set; }
        public string? Folio { get; set; }
        public Guid ClientId { get; set; }
        public Guid IdfilePdf { get; set; }
        public string? PaymentTerms { get; set; }
        public string? Address { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? Currency { get; set; }
        public bool Active { get; set; }
        public decimal SaleTax { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
    }
}
