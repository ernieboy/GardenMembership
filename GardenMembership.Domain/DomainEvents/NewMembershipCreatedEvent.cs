using MediatR;

namespace GardenMembership.Domain.DomainEvents
{
    public class NewMembershipCreatedEvent : INotification
    {
        public NewMembershipCreatedEvent()
        {
        }
    }
}
