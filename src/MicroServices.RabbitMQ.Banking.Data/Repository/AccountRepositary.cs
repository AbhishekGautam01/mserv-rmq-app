using MicroServices.RabbitMQ.Banking.Data.Context;
using MicroServices.RabbitMQ.Banking.Domain.Interfaces;
using MicroServices.RabbitMQ.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServices.RabbitMQ.Banking.Data.Repository
{
    public class AccountRepositary : IAccountRepository
    {
        private BankingDbContext _ctx;
        public AccountRepositary(BankingDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
