using System;
namespace GardenMembership.Domain.Model
{
    public class IndividualMembership : GardenMembership
    {
        public IndividualMembership(Person member)
        {
            MemberOne = member;
        }
    }
}
