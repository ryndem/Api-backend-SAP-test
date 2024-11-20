using Core.VentaDigitalPQF.Dto.Product;
using Google.Authenticator;
using Logic.VentaDigitalPQF.Interfaces;
using Logic.VentaDigitalPQF.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proxy.ProquifaDotNet.CrudTools;
using System.Net.Sockets;

namespace VentaDigitalPQF.Controllers.User
{
    [Route("[controller]")]
    [ApiController]
    public class TwoFactorController : ControllerBase
    {
        private readonly ITwoFactorService _twoFactorService;

        public  TwoFactorController(ITwoFactorService twoFactorService)
        {
                _twoFactorService = twoFactorService;
        }

        [HttpGet("GenerateQR")]
        public string Get()
        {
      
            SetupCode code = _twoFactorService.GetCodeGoogleAuthenticator("bAXKvpRf");

            return code.QrCodeSetupImageUrl;

        }

        [HttpPost("ValidatePin/{SecretKey}/{Pin}")]
        //[System.Text.Json.Serialization.JsonInclude]
        public bool Post(string SecretKey, string Pin)
        {
          
            return _twoFactorService.ValidatePin(SecretKey, Pin);           
        }
    }
}
