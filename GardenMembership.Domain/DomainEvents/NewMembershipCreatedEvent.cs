using System;
using GardenMembership.SharedKernel.Interfaces;

namespace GardenMembership.Domain.DomainEvents
{
    public class NewMembershipCreatedEvent : IDomainEvent
    {
        public NewMembershipCreatedEvent()
        {
        }
    }
}
