using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Generic
{
    public interface IGenericRepository<TEntity>
    {
        Task<IQueryable<TEntity>> GetAll(int Page=1,int Size=5);
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task<TEntity> Get(int id);

        Task save();
    }
}
