using System.ComponentModel.DataAnnotations;

namespace MuOnline.Infrastructure.Core.Models
{
    public class PagedResultRequestDto : LimitedResultRequestDto, IPagedResultRequest
    {
        [Range(0, int.MaxValue)]
        public virtual int SkipCount { get; set; }
    }
}
