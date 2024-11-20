using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProquifaDotNet.Proxy
{
    public class RequestNewToken
    {
        public string grant_type { get; set; }
        public string client_id { get; set; }
        public string password { get; set; }
        public string scope { get; set; }
        public string username { get; set; }

        public RequestNewToken(string Grant_type, string Client_id, string Password, string Scope, string Username ) { 
            grant_type = Grant_type;
            client_id = Client_id;
            password = Password;
            scope = Scope;
            username = Username;
        }
    }
}
