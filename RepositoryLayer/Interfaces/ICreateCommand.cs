using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface ICreateCommand<T> where T : class
    {
        Task<CommandResult<T>> Create(T data);
    }
}
