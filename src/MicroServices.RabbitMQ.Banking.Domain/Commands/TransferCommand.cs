using MicroservicesRabbitMQ.Domain.Core.Commands;

namespace MicroservicesRabbitMQ.Banking.Domain.Commands
{
    public class TransferCommand: Command
    {
        public int SourceAccount { get; protected set; }
        public int TargetAccount { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}
