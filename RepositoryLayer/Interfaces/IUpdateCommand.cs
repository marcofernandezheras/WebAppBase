using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IUpdateCommand<T> where T : class
    {
        Task<CommandResult<T>> Update(T data);
    }
}
