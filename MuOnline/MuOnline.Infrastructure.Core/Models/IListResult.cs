namespace MuOnline.Infrastructure.Core.Models
{
    public interface IListResult<T>
    {
        IReadOnlyList<T> Items { get; set; }
    }
}
