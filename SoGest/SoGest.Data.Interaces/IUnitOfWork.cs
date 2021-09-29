using System.Threading.Tasks;

namespace SoGest.Data.Interaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync ();
        Task ReloadEntites ();
    }
}
