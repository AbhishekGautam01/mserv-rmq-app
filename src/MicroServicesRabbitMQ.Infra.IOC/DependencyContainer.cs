using MicroServicesRabbitMQ.Bus;
using MicroServicesRabbitMQ.Domain.Core.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServicesRabbitMQ.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domaind Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
