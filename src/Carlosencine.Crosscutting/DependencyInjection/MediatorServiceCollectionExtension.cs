using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Carlosencine.Crosscutting.DependencyInjection
{
    public static class MediatorServiceCollectionExtension
    {
        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            var assembly = AppDomain.CurrentDomain.Load("Carlosencine.Application");

            services.AddMediatR(assembly);

            return services;
        }
    }
}
