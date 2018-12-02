using MediatR;

namespace GardenMembership.Domain.Commands
{
    public class NewMemberCommand : IRequest
    {       
        public PersonDetailsCommandData Member { get; set; }

        public PersonDetailsCommandData Payer { get; set; }

        public bool PayerIsMember { get; set; }

        public int MembershipType { get; set; } 

    }
}
