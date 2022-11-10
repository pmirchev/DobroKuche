namespace Microsoft.Extensions.DependencyInjection
{
    using DobroKuche.Infrastructure.Data.Common;

    public static class DobroKucheServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();

            return services;
        }
    }
}
