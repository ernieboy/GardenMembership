using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GardenMembership.Domain.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GardenMembership.Infrastructure.Persistence.Implementations
{
    public class GardenMembershipDbContext : DbContext
    {
        private readonly IMediator _mediatr;

        public GardenMembershipDbContext(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        public DbSet<Domain.Model.GardenMembership> MyProperty { get; set; }

        public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var domainEventEntities = ChangeTracker.Entries<AggregateRoot>()
                .Select(po => po.Entity)
                .Where(po => po.Events.Any())
                .ToArray();

            foreach (var entity in domainEventEntities)
            {
                var events = entity.Events.ToArray();
                entity.Events.Clear();
                foreach (var domainEvent in events)
                {
                    await _mediatr.Publish(domainEvent);
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
