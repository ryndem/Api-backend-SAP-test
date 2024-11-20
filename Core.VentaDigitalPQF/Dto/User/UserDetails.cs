using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Dto.User
{
    public class UserDetails
    {
        public Guid IdUser { get; set; }
        public string FirstNameUser { get; set; }
        public string LastNameUser { get; set; }
        public string UserName { get; set; }
        public Guid IdCustomer { get; set; }
        public Guid IdCatLanguage { get; set; }
        public string? Department { get; set; }
        public string? Position { get; set; }
        public bool AcceptTerms { get; set; }
        public bool Authentication2FA { get; set; }
        public string EmailUser { get; set; }
        public string? PhoneNumberUser { get; set; }
        public Guid IdContactPQF2 { get; set; }
        public bool PasswordValidated { get; set; }
        public string NameQustomer { get; set; }
        public string AliasCustumer { get; set; }
        public string? Sector { get; set; }
        public string? Industry { get; set; }
        public string? TaxId { get; set; }
        public string? PhoneNumberQustomer { get; set; }
        public bool FinalUser { get; set; }
        public bool Reseller { get; set; }
        public string PaymentTerms { get; set; }
        public string Currency { get; set; }
        public string EmailEVI { get; set; }
    }
}
