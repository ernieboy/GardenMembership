using GardenMembership.Domain.Model.Enums;

namespace GardenMembership.Domain.Model
{
    public abstract class GardenMembership : BaseEntity
    {
        public MembershipTypeEnum MembershipType { get; protected set; }

        public Person MemberOne { get; protected set; }

    }
}
