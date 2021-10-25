using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoGest.Data.Interaces
{
    public interface IGenericRepository<T> where T : class
    {
        
        public Task<List<T>> GetAsync ();
        public T Add ( T entity );
        public Task GetItem ( int id );
        public Task UpdateAsync ( T entity );
        public  void DeleteAsync ( T entity );
        public Task GuardarCambiosAsync ();

        


        //public bool Exist (T entity);

    }
}
