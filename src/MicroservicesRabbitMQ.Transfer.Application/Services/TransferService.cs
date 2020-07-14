using MicroservicesRabbitMQ.Banking.Application.Interfaces;
using MicroservicesRabbitMQ.Transfer.Domain.Interfaces;
using MicroservicesRabbitMQ.Transfer.Domain.Models;
using MicroServicesRabbitMQ.Domain.Core.Bus;
using System.Collections.Generic;

namespace MicroservicesRabbitMQ.Banking.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;
        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }

        public IEnumerable<AccountTransferLog> GetAccountTransferLogs()
        {
           return _transferRepository.GetAccountTransferLogs();
        }
    }
}
