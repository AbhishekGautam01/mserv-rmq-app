using MicroServices.RabbitMQ.Banking.Application.Interfaces;
using MicroServices.RabbitMQ.Banking.Application.Services;
using MicroServices.RabbitMQ.Banking.Data.Context;
using MicroServices.RabbitMQ.Banking.Data.Repository;
using MicroServices.RabbitMQ.Banking.Domain.Interfaces;
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

            //Application Services
            services.AddTransient<IAccountService, AccountService>();

            //Data Services
            services.AddTransient<IAccountRepository, AccountRepositary>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
