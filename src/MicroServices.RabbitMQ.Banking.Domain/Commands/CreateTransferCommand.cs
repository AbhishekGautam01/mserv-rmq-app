using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServices.RabbitMQ.Banking.Domain.Commands
{
    public class CreateTransferCommand: TransferCommand
    {
        public CreateTransferCommand(int from, int to, decimal amount)
        {
            SourceAccount = from;
            TargetAccount = to;
            Amount = amount;
        }
    }
}
