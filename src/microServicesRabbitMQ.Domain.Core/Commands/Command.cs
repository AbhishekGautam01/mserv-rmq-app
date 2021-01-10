using MicroservicesRabbitMQ.Domain.Core.Events;
using System;

namespace MicroservicesRabbitMQ.Domain.Core.Commands
{
    public abstract class Command: Message
    {
        //only inheriting members can set it
        public DateTime TimeStamp { get; protected set; }
        protected Command()
        {
            TimeStamp = DateTime.UtcNow;
        }
    }
}
