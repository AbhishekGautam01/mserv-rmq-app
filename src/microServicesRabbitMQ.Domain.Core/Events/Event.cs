using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServicesRabbitMQ.Domain.Core.Events
{
    //base entity
    public abstract class Event
    {
        public DateTime TimeStamp { get; protected set; }
        protected Event()
        {
            TimeStamp = DateTime.UtcNow;
        }
    }
}
