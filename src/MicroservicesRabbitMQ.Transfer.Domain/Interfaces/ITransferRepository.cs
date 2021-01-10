using MicroservicesRabbitMQ.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesRabbitMQ.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<AccountTransferLog> GetAccountTransferLogs();
    }
}
