using MicroservicesRabbitMQ.Banking.Application.Models;
using MicroservicesRabbitMQ.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroservicesRabbitMQ.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();

        void TransferFunds(AccountTransfer accountTransfer);
    }
}
