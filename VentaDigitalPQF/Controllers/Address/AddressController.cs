using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.Address;
using Logic.VentaDigitalPQF.Interfaces.Address;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proxy.ProquifaDotNet.CrudTools;

namespace VentaDigitalPQF.Controllers.Address
{
    [Route("[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressServices _addressServices;
        public AddressController(IAddressServices addressServices) => _addressServices = addressServices;
        [HttpPost("ListAddress")]
        public async Task<ActionResult<QueryResultVD<AddressDetails>>> ListAddress([FromBody] QueryInfoVD Info)
        {
            //return Ok(await _addressServices.GetAddressDetails(Info));
            string json = "{\"totalResults\":9,\"results\":[{\"idAddress\":\"cf965aa7-43f1-492b-a322-b74fb4d24b52\",\"address\":\"Calle 6 2819-a  Computec Express Guadalajara Guadalajara Jalisco 44940\",\"acceptPartials\":true},{\"idAddress\":\"fe6782c2-b626-48b5-b909-dd6191307346\",\"address\":\"Carretera San Isidro Maza 7000\\r\\n     Tlajomulco de zuñiga Jalisco 45640\",\"acceptPartials\":true},{\"idAddress\":\"fbaf6870-f4b5-47e7-8b41-26aadc4b79a8\",\"address\":\"Centro Oncológicos Edificio I\\r\\nCarretera San Isidro Maza 7000\\r\\n     Tlajomulco de Zúñiga Jalisco 45640\",\"acceptPartials\":true},{\"idAddress\":\"21f8fa94-2b0e-4638-be02-5a13352004a9\",\"address\":\"Centro Biotecnologicos 2750     GUADALAJARA GUADALAJARA 44940\",\"acceptPartials\":true},{\"idAddress\":\"9be43eb8-6595-4db6-a239-10e10a5dff30\",\"address\":\"Centro Antibióticos\\r\\nCalle 6                   2924\\r\\n     Guadalajara Jalisco 44940\",\"acceptPartials\":true},{\"idAddress\":\"8558ade1-d7d0-4c22-82a6-57cb7fe6d79f\",\"address\":\"Planta Cefalosporinas\\r\\nCalle 6 2676, Zona industrial     Guadalajara Jalisco 44940\",\"acceptPartials\":true},{\"idAddress\":\"0344cca5-cdee-4fb5-a405-987423b8ab48\",\"address\":\"Avenida España 1840  Moderna Guadalajara Guadalajara Jalisco 44190\",\"acceptPartials\":false},{\"idAddress\":\"d562bc1a-8972-4c90-939d-e70d384047bc\",\"address\":\"Carretera San Isidro Maza 7000 Edificio A S/N S/N S/N Tlajomulco de Zúñiga Tlajomulco de Zúñiga Jalisco 45640\",\"acceptPartials\":true},{\"idAddress\":\"76d6c13e-c0ea-4806-879c-c6d868804040\",\"address\":\"Avenida Miguel Ángel de Quevedo 555  Romero de Terreros Ciudad de México Ciudad de México Ciudad de México 04310\",\"acceptPartials\":true}]}";
            QueryResultVD<AddressDetails> result = JsonConvert.DeserializeObject<QueryResultVD<AddressDetails>>( json );
            return Ok( result );

        }
    }
}
