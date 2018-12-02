using System.Threading.Tasks;
using GardenMembership.SharedKernel.Interfaces;

namespace GardenMembership.Infrastructure.Persistence.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GardenMembershipDbContext _context;

        public UnitOfWork(GardenMembershipDbContext context)
        {
            _context = context;
        }

        public async Task<int> Commit()
        {
            int result = await _context.SaveChangesAsync();

            return result;
        }
    }
}
