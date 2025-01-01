using Webhook.Data;

namespace Webhook.Services.Contracts
{
    public interface IWebhookService
    {
        void Subscribe(Subscription subscription);
        Task PublishMessage(string topic, object message);
    }
}
