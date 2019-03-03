using DataLayer.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Results
{
    public class PaginatedResult<T> : PaginatedRequest where T : class
    {
        public int TotalItems { get; }
        public IEnumerable<T> Items { get; }

        public PaginatedResult(int totalItems, int itemPerPage, int currentPage, IEnumerable<T> items)
            :base(itemPerPage, currentPage)
        {
            if (totalItems < 0)
                throw new ArgumentException("TotalItems can't be less than zero.", nameof(totalItems));

            Items = items ?? throw new ArgumentException("Items can't be null.", nameof(items));
            TotalItems = totalItems;
        }

        public PaginatedResult(PaginatedRequest req, int totalItems, IEnumerable<T> items)
            : this(totalItems, req.ItemPerPage, req.CurrentPage, items)
        {
        }
    }
}
