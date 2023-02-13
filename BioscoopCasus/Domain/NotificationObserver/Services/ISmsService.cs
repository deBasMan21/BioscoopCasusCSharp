namespace BioscoopCasus.Domain.NotificationObserver.Services
{
    public interface ISmsService
    {
        public void SendSMS(string message);
    }
}