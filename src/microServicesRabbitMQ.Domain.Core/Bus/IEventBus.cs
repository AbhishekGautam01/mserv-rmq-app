using MicroServicesRabbitMQ.Domain.Core.Commands;
using MicroServicesRabbitMQ.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroServicesRabbitMQ.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T Command) where T : Command;

        void Publish<T>(T @event) where T: Event;
        void Subscribe<T, THandler>() where T : Event where THandler : IEventHandler<T>;
    }
}
