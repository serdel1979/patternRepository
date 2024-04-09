using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Model;

namespace Repository.Generic
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ContextDb _context;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(ContextDb context)
        {
            this._context = context;
            this._dbSet = _context.Set<TEntity>();
        }


        public async Task Create(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public async Task Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<TEntity> Get(int id)
        {
            TEntity find = await _dbSet.FindAsync(id);
            return find;
        }

        public async Task<IQueryable<TEntity>> GetAll(int Page = 1, int Size = 5)
        {
           return  _dbSet.Skip((Page - 1) * Size).Take(Size).AsQueryable();
        }

        public async Task save()
        {
            _context.SaveChanges();
        }

        public async Task Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
