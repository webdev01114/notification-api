namespace Notification.Api.SignalrHub
{
    public interface INotificationHub
    {
        public Task SendMessage(NotificationConatiner notification);
    }
}
