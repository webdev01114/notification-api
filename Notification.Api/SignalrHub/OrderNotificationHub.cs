using Microsoft.AspNetCore.SignalR;

namespace Notification.Api.SignalrHub
{
    public class OrderNotificationHub: Hub<INotificationHub>
    {
        public Task SubscribeToUser(string userId)
        {
            return this.Groups.AddToGroupAsync(Context.ConnectionId, userId);
        }
    }
}
