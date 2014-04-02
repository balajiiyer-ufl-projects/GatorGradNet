using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Logger : Exception
    {
        public Logger(string message) : base(message) { }
    }

    public class DataLayerException : Logger{
        public DataLayerException(string message) : base (message) { }
    }

    public class BusinessLayerException : Logger
    {
        public BusinessLayerException(string message) : base(message) { }
    }
}
