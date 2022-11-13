﻿using SportArete.Core.Contracts;
using SportArete.Core.Services;
using SportArete.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SportAreteServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}