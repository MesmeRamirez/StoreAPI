using CommonStoreAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceStoreAPI;

namespace StoreAPI.Config
{
    public static class DependenciesContainer
    {
        public static void AddMyDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ICurrentUserFactory, CurrentUserFactory>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ILikeService, LikeService>();
            services.AddScoped<ILogPriceService, LogPriceService>();
        }
    }
}
