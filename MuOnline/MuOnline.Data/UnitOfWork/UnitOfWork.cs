using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using MuOnline.Database.EF;

namespace MuOnline.Database.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _dbContext;

        public UnitOfWork(IDesignTimeDbContextFactory<MuOnlineDbContext> contextFactory)
        {
            var dbContext = contextFactory.CreateDbContext(new string[0]);
            _dbContext = dbContext;
        }
        public int Commit()
        {
            int result;
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    result = _dbContext.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw new DbUpdateException("There is an error when commit transaction", e);
                }
            }
            return result;
        }

        public object Delete(object o)
        {
            _dbContext.Remove(o);
            return o;
        }

        public void DeleteRange(IEnumerable<object> objects)
        {
            _dbContext.RemoveRange(objects);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public object Insert(object o)
        {
            _dbContext.Add(o);
            return o;
        }

        public object Update(object o)
        {
            _dbContext.Attach(o);
            _dbContext.Entry(o).State = EntityState.Modified;

            return o;
        }

        private void Dispose(bool disposing)
        {
            if (!disposing || _dbContext == null)
            {
                return;
            }
            _dbContext.Dispose();
            _dbContext = null;
        }
    }
}
