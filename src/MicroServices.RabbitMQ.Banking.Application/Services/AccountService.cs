using MicroServices.RabbitMQ.Banking.Application.Interfaces;
using MicroServices.RabbitMQ.Banking.Data.Repository;
using MicroServices.RabbitMQ.Banking.Domain.Interfaces;
using MicroServices.RabbitMQ.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServices.RabbitMQ.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepositary;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepositary = accountRepository;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepositary.GetAccounts();
        }
    }
}
