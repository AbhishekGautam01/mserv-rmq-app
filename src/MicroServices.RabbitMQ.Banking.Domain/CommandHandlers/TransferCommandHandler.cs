using MediatR;
using MicroservicesRabbitMQ.Banking.Domain.Commands;
using MicroservicesRabbitMQ.Banking.Domain.Events;
using MicroServicesRabbitMQ.Domain.Core.Bus;
using System.Threading;
using System.Threading.Tasks;

namespace MicroservicesRabbitMQ.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;
        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            //publish event to rabbit mq
            _bus.Publish(new TransferCreatedEvent(request.SourceAccount, request.TargetAccount, request.Amount));
            return Task.FromResult(true);
        }
    }
}
