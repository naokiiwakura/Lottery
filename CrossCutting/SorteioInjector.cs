using Domain.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CrossCutting
{
    public class SorteioInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Application
            //services.AddScoped<..., ...>();

            // Infra - Data
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<SorteioContext>();
        }
    }
}
