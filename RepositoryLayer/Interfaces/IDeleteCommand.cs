using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IDeleteCommand<T> where T : class
    {
        Task<CommandResult<T>> Delete(T data);
    }
}
