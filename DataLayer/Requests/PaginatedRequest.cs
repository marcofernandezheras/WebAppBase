using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Requests
{
    public class PaginatedRequest
    {
        public int ItemPerPage { get; set; }
        public int CurrentPage { get; set; }

        public PaginatedRequest() { }

        public PaginatedRequest(int itemPerPage, int currentPage)
        {
            if (itemPerPage <= 0)
                throw new ArgumentException("ItemPerPage can't be zero or less than zero.", nameof(itemPerPage));

            if (currentPage < 0)
                throw new ArgumentException("CurrentPage can't be less than zero.", nameof(currentPage));

            ItemPerPage = itemPerPage;
            CurrentPage = currentPage;
        }
    }
}
