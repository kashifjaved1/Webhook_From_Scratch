using Webhook.Services.Contracts;
using Webhook.Services.Implementation;

namespace Webhook.Extensions
{
    public static class ServiceExtensions
    {
        public static void ProjectConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IWebhookService, WebhookService>();

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
    }
}
