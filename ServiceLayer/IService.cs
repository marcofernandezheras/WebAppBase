using System;
using System.Threading.Tasks;
using DataLayer.Data;
using DataLayer.Model;
using DataLayer.Requests;
using RepositoryLayer;

namespace ServiceLayer.Services
{
    public interface IService<T, Q> where T : class where Q : class
    {
        Task<CommandResult<T>> Create(T data);
        Task<CommandResult<T>> Delete(T data);
        Task<FindResult<T>> Find(params object[] keyValues);
        Task<CommandResult<T>> Update(T data);
        Task<WhereResult<T>> Where(PaginatedRequest req, Func<Q, bool> predicate);
    }
}