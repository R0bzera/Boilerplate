using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boilerplate.Core.Configurations;

namespace Boilerplate.Core.Requests
{
    public abstract class PagedRequest : Request
    {
        public int PageNumber { get; set; } = ConfigurationPages.DefaultPageNumber;
        public int PageSize { get; set; } = ConfigurationPages.DefaultPageSize;
    }
}
