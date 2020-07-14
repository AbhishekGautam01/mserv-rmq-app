using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesRabbitMQ.Transfer.Domain.Models
{
    public class AccountTransferLog
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string AccountType { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
