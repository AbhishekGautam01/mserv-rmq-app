using MicroservicesRabbitMQ.Banking.Application.Interfaces;
using MicroservicesRabbitMQ.Banking.Application.Models;
using MicroServicesRabbitMQ.Domain.Core.Bus;
using System.Collections.Generic;
using MicroservicesRabbitMQ.Banking.Domain.Interfaces;
using MicroservicesRabbitMQ.Banking.Domain.Models;
using MicroservicesRabbitMQ.Banking.Domain.Commands;

namespace MicroservicesRabbitMQ.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepositary;
        private readonly IEventBus _bus;
        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepositary = accountRepository;
            _bus = bus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepositary.GetAccounts();
        }


        public void TransferFunds(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(accountTransfer.SourceAccount, accountTransfer.TargetAccount, accountTransfer.TransferAmount);
            _bus.SendCommand(createTransferCommand);
        }
    }
}
