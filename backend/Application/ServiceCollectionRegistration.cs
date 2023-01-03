using Application.Services;
using Core.Services;
using Ìnfrastructure.Interfaces;
using Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ServiceCollectionExtenstions
    {
        public static IServiceCollection AddServicesApplication(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton<IRephraseService, RephraseService>();
            services.AddSingleton<IGetArticleTopicsService, GetArticleTopicsService>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            return services;
        }
    }
}
