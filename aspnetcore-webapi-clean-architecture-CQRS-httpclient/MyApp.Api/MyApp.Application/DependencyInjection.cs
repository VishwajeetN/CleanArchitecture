using MediatR.NotificationPublishers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);

                // Both the handler call one by one and this is the default implementation.

                //cfg.NotificationPublisher = new ForeachAwaitPublisher();

                // Publish the event parallel for both the handler.
                cfg.NotificationPublisher = new TaskWhenAllPublisher();

            });

            return services;
        }
    }
}
