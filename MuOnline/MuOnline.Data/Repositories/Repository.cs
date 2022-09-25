using Microsoft.EntityFrameworkCore.Design;
using MuOnline.Database.EF;

namespace MuOnline.Database.Repositories
{
    public class Repository<TEntity> : RepositoryWithTPrimaryKey<TEntity, Guid>, IRepository<TEntity> where TEntity : class
    {
        public Repository(IDesignTimeDbContextFactory<MuOnlineDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }
}
