namespace Core.VentaDigitalPQF.Dto.UserRegistration
{
    public class ClientCreate
    {
        public Guid ClientId { get; set; }
        public Guid? ContactId { get; set; }
        public string? Email { get; set; }
        public string? Sector { get; set; }
        public string? Industry { get; set; }
        public string? TaxId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Position { get; set; }
        public string? Type { get; set; }
        public string? Password { get; set; }
    }
}
