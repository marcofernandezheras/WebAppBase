using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationLayer.Interfaces;

namespace ValidationLayer.ValidationPipelines
{
    public class DataValidationPipeline<T> : IValidator<T> where T : class
    {
        private readonly IList<IValidatorStep<T>> _validators;

        public DataValidationPipeline()
        {
            var type = typeof(IValidatorStep<T>);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract);
            _validators = types.Select(t => Activator.CreateInstance(t) as IValidatorStep<T>).ToList();
        }

        bool IValidator<T>.IsValid(T data, IList<InvalidProperty> errors)
        {
            var ok = true;
            foreach(var step in _validators)
            {
                ok &= step.IsValid(data, errors);
            }
            return ok && errors.Count == 0;
        }
    }
}
