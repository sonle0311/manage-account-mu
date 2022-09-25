namespace MuOnline.Infrastructure.Core.Models
{
    public class PageResultDto<T> : ListResultDto<T>, IPageResult<T>
    {
        public int TotalCount { get; set; }

        public PageResultDto(int totalCount, IReadOnlyList<T> items) : base(items)
        {
            TotalCount = totalCount;
        }
    }
}
