using System;
using System.Threading;
using System.Threading.Tasks;
using GardenMembership.Domain.DomainEvents;
using MediatR;

namespace GardenMembership.Application.DomainEventHandlers
{
    public class NewMembershipCreatedEventHandler : INotificationHandler<NewMembershipCreatedEvent>
    {
        public NewMembershipCreatedEventHandler()
        {
        }

        public Task Handle(NewMembershipCreatedEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
