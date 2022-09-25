namespace MuOnline.Infrastructure.Core.Models
{
    public interface IPageResult<T> : IListResult<T>, IHasTotalCount
    {
    }
}
