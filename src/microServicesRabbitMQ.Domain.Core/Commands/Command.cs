using MicroServicesRabbitMQ.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServicesRabbitMQ.Domain.Core.Commands
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
