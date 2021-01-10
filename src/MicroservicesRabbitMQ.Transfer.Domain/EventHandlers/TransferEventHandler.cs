using MicroservicesRabbitMQ.Transfer.Domain.Events;
using MicroServicesRabbitMQ.Domain.Core.Bus;
using System.Threading.Tasks;

namespace MicroservicesRabbitMQ.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
       public TransferEventHandler()
        {
        }
        public Task Handle(TransferCreatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}
