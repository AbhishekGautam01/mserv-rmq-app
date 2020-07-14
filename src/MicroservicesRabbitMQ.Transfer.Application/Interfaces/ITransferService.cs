using MicroservicesRabbitMQ.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesRabbitMQ.Banking.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<AccountTransferLog> GetAccountTransferLogs();

    }
}
