using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Logger : Exception
    {
        public Logger() : base() { }
        public Logger(string message) : base(message) { }
    
    
    public Logger(string format, params object[] args) : base(string.Format(format, args)) { }
    
    public Logger(string message, Exception innerException): base(message, innerException) { }

    public Logger(string format, Exception innerException, params object[] args): base(string.Format(format, args), innerException) { }
 
    }

    public class DataLayerException : Logger{
        public DataLayerException(string message) : base (message) { }

        public DataLayerException(string format, params object[] args) : base(string.Format(format, args)) { }
    
    public DataLayerException(string message, Exception innerException): base(message, innerException) { }

    public DataLayerException(string format, Exception innerException, params object[] args): base(string.Format(format, args), innerException) { }
    }

    public class BusinessLayerException : Logger
    {
        public BusinessLayerException(string message) : base(message) { }

          public BusinessLayerException(string format, params object[] args) : base(string.Format(format, args)) { }
    
    public BusinessLayerException(string message, Exception innerException): base(message, innerException) { }

    public BusinessLayerException(string format, Exception innerException, params object[] args): base(string.Format(format, args), innerException) { }
    }
}
