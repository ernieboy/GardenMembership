using System.Collections.Generic;
using MediatR;

namespace GardenMembership.Domain.Model
{
    public class AggregateRoot : BaseEntity
    {
        public AggregateRoot()
        {
            Events = new List<INotification>();
        }

        public ICollection<INotification> Events { get; }
    }
}
