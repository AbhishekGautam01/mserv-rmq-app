using MicroservicesRabbitMQ.Banking.Data.Context;
using MicroservicesRabbitMQ.Banking.Domain.Interfaces;
using MicroservicesRabbitMQ.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroservicesRabbitMQ.Banking.Data.Repository
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
