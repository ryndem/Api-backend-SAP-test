using Core.VentaDigitalPQF.Dto.UserRegistration;
using Logic.VentaDigitalPQF.Interfaces.UserRegistration;
using Microsoft.AspNetCore.Mvc;
using Proxy.ProquifaDotNet.CrudTools;

namespace VentaDigitalPQF.Controllers.UserRegistration
{
    [Route("[controller]")]
    [ApiController]
    //[Authorize( AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme )]
    public class UserRegistrationController : ControllerBase
    {

        private readonly IUserRegistrationService _userRegistrationService;
        public UserRegistrationController(IUserRegistrationService userRegistrationService)
        {
            _userRegistrationService = userRegistrationService;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserRegistrationCreate"></param>
        /// <returns></returns>
        [HttpPost]
        //[System.Text.Json.Serialization.JsonInclude]
        public async Task<ActionResult<QueryResultVD<ClientResponse>>> Post(ClientCreate UserRegistrationCreate)
        {
            return Ok(await _userRegistrationService.GetUserRegistration(UserRegistrationCreate));
        }
    }
}
