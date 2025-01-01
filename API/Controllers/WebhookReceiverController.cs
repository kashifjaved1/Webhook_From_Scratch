using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebhookReceiverController : ControllerBase
    {
        [HttpPost("/subscription/new")]
        public IActionResult AddNewSubscription(object payload)
        {
            return Ok(payload);
        }
    }
}
