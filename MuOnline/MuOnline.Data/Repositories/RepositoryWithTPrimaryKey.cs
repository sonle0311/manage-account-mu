using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using MuOnline.Database.EF;

namespace MuOnline.Database.Repositories
{
    public class RepositoryWithTPrimaryKey<TEntity, TPrimaryKey> : IRepositoryWithTPrimaryKey<TEntity, TPrimaryKey> where TEntity : class
    {
        protected readonly MuOnlineDbContext Context;
        protected readonly DbSet<TEntity> Table;
        public RepositoryWithTPrimaryKey(IDesignTimeDbContextFactory<MuOnlineDbContext> dbContextFactory)
        {
            Context = dbContextFactory.CreateDbContext(new string[0]);
            Table = Context.Set<TEntity>();
        }

        public virtual TEntity Delete(TEntity entity)
        {
            Table.Remove(entity);
            Save();

            return entity;
        }

        public virtual List<TEntity> Delete(Expression<Func<TEntity, bool>> where)
        {
            var objects = Table.Where(where).AsEnumerable();
            var dedeleteObject = objects.Select(Delete).ToList();

            return dedeleteObject;
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            var entity = Table.Where(where).FirstOrDefault();
            return entity;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return Table;
        }

        public virtual TEntity GetById(TPrimaryKey id)
        {
            return Table.Find(id);
        }

        public virtual IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return Table.Where(where);
        }

        public virtual TEntity Insert(TEntity entity)
        {
            Table.Add(entity);
            Save();

            return entity;
        }

        public virtual bool InsertRange(List<TEntity> entities)
        {
            Table.AddRange(entities);
            return Context.SaveChanges() > 0;
        }

        public virtual void Save()
        {
            Context.SaveChanges();
        }

        public virtual TEntity Update(TEntity entity)
        {
            Table.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
            Save();

            return entity;
        }
    }
}
