using System;
using System.Threading;
using System.Threading.Tasks;
using GardenMembership.Domain.Commands;
using GardenMembership.Infrastructure.Persistence.Implementations;
using GardenMembership.SharedKernel.Interfaces;
using MediatR;

namespace GardenMembership.Application.CommandHandlers
{
    public class NewMembershipCommanHandler : IRequestHandler<NewMemberCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly GardenMembershipDbContext _dbContext;

        public NewMembershipCommanHandler(IUnitOfWork unitOfWork, GardenMembershipDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _dbContext = dbContext;
        }

        public Task<Unit> Handle(NewMemberCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
