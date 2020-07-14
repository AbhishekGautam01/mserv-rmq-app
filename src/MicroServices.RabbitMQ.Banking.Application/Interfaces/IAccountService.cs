using MicroServices.RabbitMQ.Banking.Application.Models;
using MicroServices.RabbitMQ.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServices.RabbitMQ.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();

        void TransferFunds(AccountTransfer accountTransfer);
    }
}
