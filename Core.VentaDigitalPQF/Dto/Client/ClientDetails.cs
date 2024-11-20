using Core.VentaDigitalPQF.Dto.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Dto.Client
{
    public class ClientDetails
    {
        public ClientDetails()
        {
            Address = new List<AddressDetails>();
        }

        public Guid ClientId { get; set; }
        public string? Email { get; set; }
        public string? Sector { get; set; }
        public string? Industry { get; set; }
        public string? TaxId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Position { get; set; }
        public string? Type { get; set; }
        public string? EmailEVI { get; set; }

        public List<AddressDetails> Address { get; set; }
    }
}
