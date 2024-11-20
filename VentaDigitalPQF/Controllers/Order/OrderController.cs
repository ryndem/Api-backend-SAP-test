using Core.VentaDigitalPQF.CrudTools;
using Core.VentaDigitalPQF.Dto.Order;
using Core.VentaDigitalPQF.Dto.Order.OrderItem;
using Logic.VentaDigitalPQF.Interfaces.Order;
using Microsoft.AspNetCore.Mvc;
using Proxy.ProquifaDotNet.CrudTools;

namespace VentaDigitalPQF.Controllers.Order
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpPost("ListOrder")]
        public async Task<ActionResult<QueryResultVD<OrderSummary>>> ListOrder()
        {
            return Ok(await _orderService.GetListOrder());
        }
        [HttpGet("OrderDetails")]
        public async Task<ActionResult<OrderDetails>> GetOrderDetails(Guid IdOrder)
        {
            return Ok(await _orderService.GetOrderDetails(IdOrder));
        }
        [HttpPost("ListOrderItemsDetails")]
        public async Task<ActionResult<QueryResultVD<OrderItemDetails>>> PostListOrderItemsDetails(QueryInfoVD Info)
        {
            return Ok(await _orderService.ListOrderItemsDetails(Info));
        }
    }
}
