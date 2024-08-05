using GetStarted.Wpf.PrismApp.Services.Interfaces;

namespace GetStarted.Wpf.PrismApp.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
