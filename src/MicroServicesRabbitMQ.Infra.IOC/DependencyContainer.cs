using MediatR;
using MicroservicesRabbitMQ.Banking.Application.Interfaces;
using MicroservicesRabbitMQ.Banking.Application.Services;
using MicroservicesRabbitMQ.Banking.Data.Context;
using MicroservicesRabbitMQ.Banking.Data.Repository;
using MicroservicesRabbitMQ.Banking.Domain.CommandHandlers;
using MicroservicesRabbitMQ.Banking.Domain.Commands;
using MicroservicesRabbitMQ.Banking.Domain.Interfaces;
using MicroservicesRabbitMQ.Bus;
using MicroservicesRabbitMQ.Transfer.Data.Context;
using MicroservicesRabbitMQ.Transfer.Data.Repository;
using MicroservicesRabbitMQ.Transfer.Domain.EventHandlers;
using MicroservicesRabbitMQ.Transfer.Domain.Events;
using MicroservicesRabbitMQ.Transfer.Domain.Interfaces;
using MicroServicesRabbitMQ.Domain.Core.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroServicesRabbitMQ.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            ////Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            ////Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            ////Domain Transfer Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            ////Application Services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            ////Data Services
            services.AddTransient<IAccountRepository, AccountRepositary>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}
