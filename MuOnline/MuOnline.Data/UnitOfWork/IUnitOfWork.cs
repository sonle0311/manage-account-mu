namespace MuOnline.Database.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        object Insert(object o);

        object Update(object o);

        object Delete(object o);

        void DeleteRange(IEnumerable<object> objects);

        int Commit();
    }
}
