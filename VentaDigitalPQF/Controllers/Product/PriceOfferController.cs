//using Core.CrudTools.Optimization;
using Proxy.ProquifaDotNet.CrudTools;
using Proxy.ProquifaDotNet.Model;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Core.VentaDigitalPQF.Dto.Product;
using Core.VentaDigitalPQF.ExceptionHandler;
using Logic.VentaDigitalPQF.Interfaces.Product;
using System;
using System.Text.Json;
using Microsoft.IdentityModel.Tokens;
using Core.VentaDigitalPQF.Dto.PriceOffert;
using Core.VentaDigitalPQF.Dto.ProductCustomerWeb.SearchSuggestion;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VentaDigitalPQF.Controllers.PriceOffer
{
    [Route( "[controller]" )]
    [ApiController]
    //[Authorize]

    public class PriceOfferController : ControllerBase
    {
        /// <summary>
        /// Obtiene la oferta de un producto de un usuario logueado
        /// </summary>
        /// <param name="PriceOfferVDRequest"></param>
        /// <returns>Retorna Detalles de la oferta de un producto</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /PriceOfferVD
        ///     {
        ///        PriceOfferVDRequest
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Retorna objeto de PriceOfferRead</response>
        /// <response code="400">No se encuentra el objeto PriceOfferRead</response>


        [HttpPost( "PriceOfferVD" )]
        public async Task<ActionResult<PriceOfferRead>> PriceOfferVD( [FromBody]PriceOfferVDRequest request )
        {
            var json = "{\"unitPrice\":989.0,\"stockDeliveryTime\":null,\"stockDeliveryTimeDays\":null,\"hasStock\":false}";
            var priceOffer = JsonConvert.DeserializeObject<PriceOfferRead>( json );
            return Ok( priceOffer );
        }
        /// <summary>
        /// Obtiene datos de oferta de un producto cuando el usuario no esta logueado
        /// </summary>
        /// <param name="PriceOfferWebRequest"></param>
        /// <returns>Retorna Detalles de la oferta de un producto</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /PriceOfferWeb
        ///     {
        ///        PriceOfferWebRequest
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Retorna objeto de PriceOfferRead</response>
        /// <response code="400">No se encuentra el objeto PriceOfferRead</response>


        [HttpPost( "PriceOfferWeb" )]
        public async Task<ActionResult<PriceOfferRead>> PriceOfferWeb( [FromBody] PriceOfferWebRequest request )
        {
            var json = "{\"unitPrice\":5769.0,\"stockDeliveryTime\":\"2 Dias\",\"stockDeliveryTimeDays\":2.000000,\"hasStock\":true}";
            var priceOffer = JsonConvert.DeserializeObject<PriceOfferRead>( json );
            return Ok( priceOffer );
        }
    }
}
