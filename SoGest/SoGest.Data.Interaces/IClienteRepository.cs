using SoGest.Data.Model.Entities;

using System.Threading.Tasks;

namespace SoGest.Data.Interaces
{
    public interface IClienteRepository : IGenericRepository<Cliente>
    {
        public Task<Cliente> GetClienteByIdAsync ( int id );
        public Task<bool> ExistAsync ( int id );
    }
}
