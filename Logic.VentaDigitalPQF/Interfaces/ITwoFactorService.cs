using Google.Authenticator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.VentaDigitalPQF.Interfaces
{
    public interface ITwoFactorService
    {
        public SetupCode GetCodeGoogleAuthenticator(string secretKey);
        public bool ValidatePin(string secretKey, string pin);
    }
}
