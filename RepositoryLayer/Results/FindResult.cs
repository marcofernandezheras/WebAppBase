using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class FindResult<T> where T : class
    {
        public T Data { get; }
        public Exception Error { get; }
        public bool Success { get; }

        public FindResult(T data)
        {
            Error = null;
            Data = data;
            Success = true;
        }

        public FindResult(Exception ex)
        {
            Data = null;
            Error = ex;
            Success = false;
        }
    }
}
