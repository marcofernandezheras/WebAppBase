using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationLayer.Interfaces
{
    public interface IValidatorStep<T> where T : class
    {
        bool IsValid(T data, IList<InvalidProperty> errors);
    }
}
