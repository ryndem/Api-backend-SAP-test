using Core.VentaDigitalPQF.Dto.User;
using log4net;
using Logic.VentaDigitalPQF.Interfaces.IdentityServer;
using Logic.VentaDigitalPQF.Interfaces.User;
using Microsoft.AspNetCore.Mvc;

namespace VentaDigitalPQF.Controllers
{
    [ApiController]
    //[Route("")]*/

    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly IVentaDigitalAccessManager _ventaDigitalAccessManager;

        public HomeController(IUserService userService, IVentaDigitalAccessManager ventaDigitalAccessManager)
        {
            _userService = userService;
            _ventaDigitalAccessManager = ventaDigitalAccessManager;
        }

        [HttpPost]
        [Route("WhoAmI")]
        public async Task<ActionResult<UserDetails>> Post()
        {
            var header = Request.Headers.FirstOrDefault(h => h.Key.Equals("Authorization"));
            if (header.Key == null)
                return BadRequest("No se ha enviado el token de autorización");
            else
            {
                ThreadContext.Properties["username"] = null;
                var accessToken = header.Value.ToString().Split(" ")[1];
                var username = _ventaDigitalAccessManager.ObtenerUserName(accessToken);
                var usuario = await _userService.GetByUserName(username);

                if (username == null)
                    return null;

                return Ok(await _userService.GetByUserName(username));

            }


        }
    }
}
