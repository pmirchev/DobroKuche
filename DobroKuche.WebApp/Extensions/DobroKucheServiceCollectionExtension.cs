namespace Microsoft.Extensions.DependencyInjection
{
    using DobroKuche.Core.Contracts;
    using DobroKuche.Core.Services;
    using DobroKuche.Infrastructure.Data.Common;

    public static class DobroKucheServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<ICourseService, CourseService>();

            return services;
        }
    }
}
