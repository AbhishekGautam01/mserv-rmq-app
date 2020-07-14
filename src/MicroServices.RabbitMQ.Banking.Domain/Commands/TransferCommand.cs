using MicroServicesRabbitMQ.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServices.RabbitMQ.Banking.Domain.Commands
{
    public class TransferCommand: Command
    {
        public int SourceAccount { get; protected set; }
        public int TargetAccount { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}
