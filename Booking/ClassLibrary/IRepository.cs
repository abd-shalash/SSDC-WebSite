using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    interface IRepository<TEntity>
    {
        void Create(TEntity entity);
        TEntity Read(int id);
        void Update(TEntity entity);
        void Delete(int id);

        IEnumerable<TEntity> ReadWhere(Func<TEntity, bool> predicate);
        IEnumerable<TEntity> ReadAll();
    }
}
