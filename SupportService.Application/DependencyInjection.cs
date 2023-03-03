
using Microsoft.Extensions.DependencyInjection;
using SupportService.Application.Services.AuthService;

namespace SupportService.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            return services;
        }
    }
}
