using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class CommandResult<T> where T : class
    {
        public Exception Error { get; set; }
        public T InputData { get; set; }
        public T OuputData { get; set; }
        public bool Success { get; set; }

        public CommandResult() { }

        public CommandResult(T input, T output, bool success = true)
        {
            this.Error = null;
            this.InputData = input;
            this.OuputData = output;
            this.Success = success;
        }

        public CommandResult(T input, Exception ex)
        {
            this.Error = ex;
            this.InputData = input;
            this.OuputData = null;
            this.Success = false;
        }
    }
}
