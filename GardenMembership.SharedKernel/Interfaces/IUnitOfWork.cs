using System.Threading.Tasks;

namespace GardenMembership.SharedKernel.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> Commit();
    }
}
