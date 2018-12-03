using System;
namespace GardenMembership.Domain.Model
{
    public class JointMembership : GardenMembership
    {
        public JointMembership(Person memberOne, Person memberTwo)
        {
            MemberOne = memberOne;
            MemberTwo = memberTwo;
        }

        public Person MemberTwo { get; protected set; }
    }
}
