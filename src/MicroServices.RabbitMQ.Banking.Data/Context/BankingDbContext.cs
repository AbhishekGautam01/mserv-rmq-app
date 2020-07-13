using MicroServices.RabbitMQ.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServices.RabbitMQ.Banking.Data.Context
{
    public class BankingDbContext: DbContext
    {
        public BankingDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
