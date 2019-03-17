using DataLayer.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class WhereResult<T> where T : class
    {
        public PaginatedResult<T> Data { get; set; }
        public Exception Error { get; set; }
        public bool Success { get; set; }

        public WhereResult(PaginatedResult<T> data)
        {
            Error = null;
            Data = data;
            Success = true;
        }

        public WhereResult(Exception ex)
        {
            Data = null;
            Error = ex;
            Success = false;
        }
    }
}
