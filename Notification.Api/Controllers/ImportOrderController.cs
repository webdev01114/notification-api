using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Notification.Api.SignalrHub;

namespace Notification.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportOrderController : ControllerBase
    {
        private readonly IHubContext<OrderNotificationHub, INotificationHub> _orderNotification;

        public ImportOrderController(IHubContext<OrderNotificationHub, INotificationHub> hubContext)
        {
            _orderNotification = hubContext;
        }
        [HttpGet]
        public async Task<IActionResult> createOrder()
        {
            try
            {
                await _orderNotification.Clients.Group("1").SendMessage(new NotificationConatiner
                {
                    userId = "1",
                    name = "Bulk Order",
                    message = "Order Created"
                });
                return Ok("Order Created Successfully.");
            }
            catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
        }
    }
}
