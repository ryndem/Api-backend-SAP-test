using Core.VentaDigitalPQF.Dto.User;
using Logic.VentaDigitalPQF.Interfaces.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VentaDigitalPQF.Controllers.User
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    

    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{IdUser}")]
        public async Task<ActionResult<UserDetails>> Get(Guid IdUser)
        {
            return Ok(await _userService.GetUserDetails(new UserRequest { IdUser = IdUser }));
        }
    }
}
