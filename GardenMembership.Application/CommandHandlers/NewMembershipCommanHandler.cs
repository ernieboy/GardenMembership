using System;
using System.Threading;
using System.Threading.Tasks;
using GardenMembership.Domain.Commands;
using GardenMembership.SharedKernel.Interfaces;
using MediatR;

namespace GardenMembership.Application.CommandHandlers
{
    public class NewMembershipCommanHandler : IRequestHandler<NewMemberCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public NewMembershipCommanHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<Unit> Handle(NewMemberCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
