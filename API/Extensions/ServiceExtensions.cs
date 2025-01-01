namespace Client.Extensions
{
    public static class ServiceExtensions
    {
        public static void ProjectConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddHttpClient();
        }
    }
}
