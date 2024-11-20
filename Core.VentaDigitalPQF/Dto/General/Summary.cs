namespace Core.VentaDigitalPQF.Dto.General
{
    public class Summary
    {
        public string? Folio { get; set; }
        public Guid IdfilePdf { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int Items { get; set; }
        public int Total { get; set; }
    }
}
