using MicroservicesRabbitMQ.Transfer.Data.Context;
using MicroservicesRabbitMQ.Transfer.Domain.Interfaces;
using MicroservicesRabbitMQ.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroservicesRabbitMQ.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _ctx;
        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<AccountTransferLog> GetAccountTransferLogs()
        {
            return _ctx.TransferAcountLogs;
        }
    }
}
