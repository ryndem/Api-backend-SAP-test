using Core.VentaDigitalPQF.Dto.SuggestedContact;
using Logic.VentaDigitalPQF.Interfaces.SuggestedContact;
using Microsoft.AspNetCore.Mvc;
using Proxy.ProquifaDotNet.CrudTools;

namespace VentaDigitalPQF.Controllers.SuggestedContact
{
    [Route("[controller]")]
    [ApiController]
    //[Authorize( AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme )]
    public class SuggestedContactController : ControllerBase
    {

        private readonly ISuggestedContactService _suggestedContactService;
        public SuggestedContactController(ISuggestedContactService suggestedContactService)
        {
            _suggestedContactService = suggestedContactService;
        }
        /// <summary>
        /// Obtener cliente sugerido segun el contacto y RFC.
        /// </summary>
        /// <param name="SuggestedContactRequest"> Modelo de entrada con los campos Correo y RFC</param>
        /// <returns>Modelo con datos del cliente sugerido por coincidencia</returns>
        [HttpPost]
        //[System.Text.Json.Serialization.JsonInclude]
        public async Task<ActionResult<QueryResultVD<SuggestedContactDetails>>> Post(SuggestedContactRequest SuggestedContactRequest)
        {
            return Ok(await _suggestedContactService.GetSuggestedContact(SuggestedContactRequest));
        }
    }
}
