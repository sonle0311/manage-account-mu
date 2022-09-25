namespace MuOnline.Infrastructure.Core.Models
{
    public interface IPagedResultRequest : ILimitedResultRequest
    {
        int SkipCount { get; set; }
    }
}
