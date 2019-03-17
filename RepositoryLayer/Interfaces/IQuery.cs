using DataLayer.Requests;
using DataLayer.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IQuery<T, Q> where T : class where Q : class
    {
        Task<FindResult<T>> Find(params object[] keyValues);
        Task<WhereResult<T>> Where(PaginatedRequest req, Func<Q, bool> predicate);
    }
}
