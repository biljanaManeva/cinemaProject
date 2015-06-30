using Cinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
        void Save();

    }
}
