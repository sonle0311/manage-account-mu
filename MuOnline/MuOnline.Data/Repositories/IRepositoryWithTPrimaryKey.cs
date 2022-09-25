using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MuOnline.Database.Repositories
{
    public interface IRepositoryWithTPrimaryKey<TEntity, in TPrimaryKey> where TEntity : class
    {
        TEntity GetById(TPrimaryKey id);

        TEntity Get(Expression<Func<TEntity, bool>> where);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);

        TEntity Insert(TEntity entity);

        bool InsertRange(List<TEntity> entities);

        TEntity Update(TEntity entity);

        TEntity Delete(TEntity entity);

        List<TEntity> Delete(Expression<Func<TEntity, bool>> where);

        void Save();
    }
}
