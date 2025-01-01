using Client.Data;
using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SubscriptionController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;
        private readonly string _webhookBaseUrl;

        public SubscriptionController(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _httpClient = _httpClientFactory.CreateClient();
            _webhookBaseUrl = _configuration["Links:WebhookBaseUrl"]!;
        }

        [HttpPost]
        public async Task Subscribe(string topic)
        {
            var callbackUri = _configuration["Links:CallbackUrl"]!;
            var subscription = new Subscription(topic, callbackUri);

            await _httpClient.PostAsJsonAsync($"{_webhookBaseUrl}/subscribe", subscription);
        }

        [HttpPost]
        public async Task Publish(PublishRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_webhookBaseUrl}/publish", request);
        }
    }
}
