using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boilerplate.Core.Configurations;

namespace Boilerplate.Core.Responses
{
    public class PagedResponse<TData> : Response<TData>
    {
        public PagedResponse(TData? data, int totalCount, int currentPage = 1, int pageSize = ConfigurationPages.DefaultPageSize)
        {
            Data = data;
            TotalCount = totalCount;
            CurrentPage = currentPage;
            PageSize = pageSize;
        }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
        public int PageSize { get; set; } = ConfigurationPages.DefaultPageSize;
        public int TotalCount { get; set; }
    }
}
