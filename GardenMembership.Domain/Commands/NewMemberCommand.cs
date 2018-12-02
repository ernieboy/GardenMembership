using GardenMembership.Domain.Model;
using MediatR;

namespace GardenMembership.Domain.Commands
{
    public class NewMemberCommand : IRequest
    {       
        public Person Person { get; set; }
    }
}
