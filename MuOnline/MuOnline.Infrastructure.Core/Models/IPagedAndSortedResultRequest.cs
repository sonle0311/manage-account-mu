using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuOnline.Infrastructure.Core.Models
{
    public interface IPagedAndSortedResultRequest : IPagedResultRequest, ISortedResultRequest
    {
    }
}
