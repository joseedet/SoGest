using Microsoft.EntityFrameworkCore;

using SoGest.Data.Interaces;
using SoGest.Data.Model.Entities;

using System.Threading.Tasks;

namespace SoGest.Data.Repositories
{
    public class ClienteRepository:GenericReopsitory<Cliente>,IClienteRepository
    {
        private readonly ISoGestRepositoryContext _clienteRepository;

        public ClienteRepository(ISoGestRepositoryContext dbContext):base(dbContext)
        {
            _clienteRepository = dbContext;

        }       

       public async Task<Cliente> GetClienteByIdAsync (int id)
        {           
              return  await _clienteRepository.Clientes.FirstOrDefaultAsync(m => m.Id == id); 
            
        }
        public async Task<bool> ExistAsync ( int id )
        {
            return await _clienteRepository.Set<Cliente>().AnyAsync(e => e.Id == id);
        }
       
    }
}
