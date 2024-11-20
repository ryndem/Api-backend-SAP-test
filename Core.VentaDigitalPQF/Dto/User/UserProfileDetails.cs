using Core.VentaDigitalPQF.Dto.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.VentaDigitalPQF.Dto.User
{
    public class UserProfileDetails
    {
        public UserProfileDetails()
        {
            Client = new ClientDetails();
        }

        public Guid IdUser{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid IdClient { get; set; }
        public Guid IdCatLanguage { get; set; }
        public string? Department { get; set; }
        public string? Position { get; set; }
        public bool AcceptTerms { get; set; }
        public string Authentication2FA { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ClientDetails Client { get; set; }

        
    }


}
