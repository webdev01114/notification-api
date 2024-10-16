using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Notification.Api.SignalrHub;

namespace Notification.Api.Controllers
{
    public class OrderController : Controller
    {
        private readonly IHubContext<OrderNotificationHub, INotificationHub> _orderNotification;

        public OrderController(IHubContext<OrderNotificationHub, INotificationHub> hubContext) {
            _orderNotification = hubContext;
        }
        public IActionResult Index()
        {
            return Ok("This is a Order Page.");
        }
    }
}
