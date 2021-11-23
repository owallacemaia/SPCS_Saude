using MediatR;
using System;

namespace SPCS.Saude.Core.Messages
{
    public class Event : Message, INotification
    {
        public DateTime Timestamp { get; set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
