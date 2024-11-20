using Google.Authenticator;
using Logic.VentaDigitalPQF.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.VentaDigitalPQF.Services
{
    public class TwoFactorService : ITwoFactorService
    {
        private readonly IConfiguration _config;
       
        public TwoFactorService(IConfiguration config)
        {
            _config = config;
        }

        public SetupCode GetCodeGoogleAuthenticator(string secretKey)
        {
            secretKey = "bAXKvpRf";

            TwoFactorAuthenticator autenticator = new TwoFactorAuthenticator();

            string? GoogleAuthenticatorissuer = _config["GoogleAuthenticatorissuer"];
            string? GoogleAuthenticatoraccountTitle = _config["GoogleAuthenticatoraccountTitle"];

            var issuer = GoogleAuthenticatorissuer ?? "Venta Digital";

            var accountTitle = GoogleAuthenticatoraccountTitle ?? "PinValidate";

            var setupInfo = autenticator.GenerateSetupCode(issuer, accountTitle, secretKey, false, 6);

            return setupInfo;
        }
        public bool ValidatePin(string secretKey, string pin)
        {
            TwoFactorAuthenticator autenticator = new TwoFactorAuthenticator();

            var validate = autenticator.ValidateTwoFactorPIN(secretKey, pin, TimeSpan.FromSeconds(30));

            return validate;
        }
    }
}
