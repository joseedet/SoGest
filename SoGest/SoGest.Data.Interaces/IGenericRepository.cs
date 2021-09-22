using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoGest.Data.Interaces
{
    public interface IGenericRepository<T> where T : class
    {
       public  Task<List<T>> GetAsync();

        public T Add( T entity );
    }
}
