using Microsoft.EntityFrameworkCore;

using SoGest.Data.Interaces;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoGest.Data.Repositories
{
    public class GenericReopsitory<T> : IGenericRepository<T> where T : class
    {
        private ISoGestDbContext _dbContext;
        private DbSet<T> _dbSet;

        public GenericReopsitory ( ISoGestDbContext dbContext )
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>( );

        }
        public DbSet<T> DbSet
        {
            get => _dbSet ?? ( _dbSet = _dbContext.Set<T>( ) );
            set => _dbSet = value;

        }
        public ISoGestDbContext DbContext
        {
            get { return _dbContext; }
            private set { _dbContext = value; }

        }
        public virtual T Add ( T entity )
        {
            var entry = _dbSet.Add(entity).Entity;
            return entry;
            //return entry;
        }

        public virtual  void DeleteAsync ( T entity )
        {
            _dbSet.Remove(entity);
        }

        //public async void GuardarCambiosAsync () 
        //{
        //    await _dbContext.SaveChangesAsync( );
        //}



        //public bool Exist ( T entity)
        //{
        //    return _dbSet.Any(entity=> entity. == id);
        //}

        public virtual async Task<List<T>> GetAsync ()
        {
            return await _dbSet.ToListAsync( );
        }

        public virtual async Task GetItem ( int id )
        {

            await _dbSet.FindAsync(id);

            //throw new NotImplementedException( );
        }

        public virtual async Task UpdateAsync ( T entity )
        {
            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync( );
        }

        public virtual async Task GuardarCambiosAsync()
        {

            await _dbContext.SaveChangesAsync( );
        }
    }
}
