namespace BioscoopCasus.Domain.NotificationObserver.Services
{
    public interface IWhatsappService
    {
        public void SendWhatsappMessage(string message);
    }
}