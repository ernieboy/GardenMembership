using System;
using System.Threading;
using System.Threading.Tasks;
using GardenMembership.Domain.Commands;
using MediatR;

namespace GardenMembership.Application.CommandHandlers
{
    public class NewMembershipCommanHandler : IRequestHandler<NewMemberCommand>
    {
        public NewMembershipCommanHandler()
        {
        }

        public Task<Unit> Handle(NewMemberCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
