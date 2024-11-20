using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.PurchaseOrder;
using Core.VentaDigitalPQF.Dto.PurchaseOrder.PurchaseOrderItem;
using Logic.VentaDigitalPQF.Interfaces.PurchaseOrder;
using Microsoft.AspNetCore.Mvc;
using Proxy.ProquifaDotNet.CrudTools;

namespace VentaDigitalPQF.Controllers.PurchaseOrder
{
    [Route("[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly IPurchaseOrderService _purchaseOrderService;
        public PurchaseOrderController(IPurchaseOrderService purchaseOrderService) => _purchaseOrderService = purchaseOrderService;
        [HttpPost("ListPurchaseOrder")]
        public async Task<ActionResult<QueryResultVD<PurchaseOrderSummary>>> ListPurchaseOrder()
        {
            return Ok(await _purchaseOrderService.GetListPurchaseOrder());
        }
        [HttpGet("PurchaseOrderDetails")]
        public async Task<ActionResult<PurchaseOrderDetails>> GetPurchaseOrderDetails(Guid IdPurchaseOrder)
        {
            return Ok(await _purchaseOrderService.GetPurchaseOrderDetails(IdPurchaseOrder));
        }
        [HttpPost("ListPurchaseOrderItemsDetails")]
        public async Task<ActionResult<QueryResultVD<PurchaseOrderItemDetails>>> PostListPurchaseOrderItemsDetails(QueryInfoVD Info)
        {
            return Ok(await _purchaseOrderService.ListPurchaseOrderItemsDetails(Info));
        }
    }
}
