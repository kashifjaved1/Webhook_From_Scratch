using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webhook.Data;
using Webhook.Services.Contracts;

namespace Webhook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        private IWebhookService _webhookService;

        public WebhookController(IWebhookService webhookService)
        {
            _webhookService = webhookService;
        }

        [HttpPost("/subscribe")]
        public async Task Subscribe(Subscription subscription)
        {
            _webhookService.Subscribe(subscription);
        }

        [HttpPost("/publish")]
        public async Task Publish(PublishRequest request)
        {
            await _webhookService.PublishMessage(request.Topic, request.Message);
        }
    }
}
