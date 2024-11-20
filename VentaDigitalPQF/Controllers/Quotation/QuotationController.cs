using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.Quotation;
using Core.VentaDigitalPQF.Dto.Quotation.QuotationItem;
using Logic.VentaDigitalPQF.Interfaces.Quotation;
using Microsoft.AspNetCore.Mvc;
using Proxy.ProquifaDotNet.CrudTools;

namespace VentaDigitalPQF.Controllers.Quotation
{
    [Route("[controller]")]
    [ApiController]
    public class QuotationController : ControllerBase
    {
        private readonly IQuotationService _quotationService;
        public QuotationController(IQuotationService quotationService) => _quotationService = quotationService;
        //EndPoints
        [HttpPost("GetShoppingCart")]
        public async Task<ActionResult<QuotationSendResponse>> GetShoppingCart()
        {
            return Ok(await _quotationService.GetShoppingCart());
        }
        [HttpPost("PutShoppingCart")]
        public async Task<ActionResult<QuotationItemDetails>> PutShoppingCart(QuotationItemSCarRequest QuotationItemSCarRequest)
        {
            return Ok(await _quotationService.PutShoppingCart(QuotationItemSCarRequest));
        }
        [HttpPost("RefreshShoppingCart")]
        public async Task<ActionResult<QuotationRefreshResponse>> RefreshShoppingCart(QuotationRefreshRequets GMQuotationRefreshRequets)
        {
            return Ok(await _quotationService.RefreshShoppingCart(GMQuotationRefreshRequets));
        }
        [HttpPost("SendQuotation")]
        public async Task<ActionResult<QuotationSendResponse>> SendQuotation(QuotationRefreshRequets GMQuotationRefreshRequets)
        {
            return Ok(await _quotationService.SendQuotation(GMQuotationRefreshRequets));
        }
        [HttpPost]
        public async Task<ActionResult<QueryResultVD<QuotationDetails>>> Post()
        {
            return Ok(await _quotationService.Post());
        }
        [HttpGet]
        public async Task<ActionResult<QuotationSendResponse>> Get(Guid IdQuotation)
        {
            return Ok(await _quotationService.Get(IdQuotation));
        }
        [HttpPost("ListQuotation")]
        public async Task<ActionResult<QueryResultVD<QuotationSummary>>> ListQuotation()
        {
            return Ok(await _quotationService.GetListQuotation());
        }
        [HttpPost("ListQuotationItemsDetails")]
        public async Task<ActionResult<QueryResultVD<QuotationItemDetails>>> PostListQuotationItems(QueryInfoVD Info)
        {
            return Ok(await _quotationService.ListQuotationItemsDetails(Info));
        }
    }
}
