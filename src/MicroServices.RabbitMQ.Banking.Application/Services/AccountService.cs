using MicroServices.RabbitMQ.Banking.Application.Interfaces;
using MicroServices.RabbitMQ.Banking.Application.Models;
using MicroServices.RabbitMQ.Banking.Data.Repository;
using MicroServices.RabbitMQ.Banking.Domain.Commands;
using MicroServices.RabbitMQ.Banking.Domain.Interfaces;
using MicroServices.RabbitMQ.Banking.Domain.Models;
using MicroServicesRabbitMQ.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServices.RabbitMQ.Banking.Application.Services
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
