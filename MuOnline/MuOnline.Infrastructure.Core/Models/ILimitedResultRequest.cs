namespace MuOnline.Infrastructure.Core.Models
{
    public interface ILimitedResultRequest
    {
        int MaxResultCount { get; set; }
    }
}
