using Webhook.Data;
using Webhook.Services.Contracts;

namespace Webhook.Services.Implementation
{
    public class WebhookService : IWebhookService
    {
        private readonly List<Subscription> _inMemorySubscriptions = new();
        private readonly HttpClient _httpClient = new();

        public void Subscribe(Subscription subscription)
        {
            _inMemorySubscriptions.Add(subscription);
        }

        public async Task PublishMessage(string topic, object message)
        {
            var subscriptions = _inMemorySubscriptions.Where(x => x.Topic == topic);
            foreach (var subscription in subscriptions)
            {
                await _httpClient.PostAsJsonAsync(subscription.CallbackUri, message);
            }
        }
    }
}
