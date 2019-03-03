using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationLayer
{
    public class InvalidProperty
    {
        public string PropertyName { get; }
        public string Reason { get; }

        public InvalidProperty(string propertyName, string reason)
        {
            PropertyName = propertyName;
            Reason = reason;
        }
    }
}
