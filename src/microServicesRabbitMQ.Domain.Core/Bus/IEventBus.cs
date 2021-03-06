﻿using MicroservicesRabbitMQ.Domain.Core.Commands;
using MicroservicesRabbitMQ.Domain.Core.Events;
using System.Threading.Tasks;

namespace MicroServicesRabbitMQ.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T Command) where T: Command;

        void Publish<T>(T @event) where T: Event;
        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
