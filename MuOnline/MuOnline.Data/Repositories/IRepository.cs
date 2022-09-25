namespace MuOnline.Database.Repositories
{
    public interface IRepository<TEntity> : IRepositoryWithTPrimaryKey<TEntity, Guid> where TEntity : class
    {
    }
}
