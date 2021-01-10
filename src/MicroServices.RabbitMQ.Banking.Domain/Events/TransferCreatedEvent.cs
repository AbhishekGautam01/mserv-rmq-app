using MicroservicesRabbitMQ.Domain.Core.Events;

namespace MicroservicesRabbitMQ.Banking.Domain.Events
{
    public class TransferCreatedEvent: Event
    {
        // we have made this private as we dont want the event to be modified anywhere
        public int SourceAccount { get; private set; }
        public int TargetAccount { get; private set; }
        public decimal Amount { get; private set; }
        public TransferCreatedEvent(int from, int to, decimal amount)
        {
            SourceAccount = to;
            TargetAccount = from;
            Amount = amount;
        }
    }
}
