using MicroservicesRabbitMQ.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesRabbitMQ.Transfer.Data.Context
{
    public class TransferDbContext: DbContext
    {
        public TransferDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<AccountTransferLog> TransferAcountLogs { get; set; }
    }
}
