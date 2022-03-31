using ArzonMarket.Data.IRepositories;
using ArzonMarket.Data.Repositories;
using ArzonMarket.Service.Interfaces;
using ArzonMarket.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ArzonMarket.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IClientService, ClientService>();
        }
    }
}
