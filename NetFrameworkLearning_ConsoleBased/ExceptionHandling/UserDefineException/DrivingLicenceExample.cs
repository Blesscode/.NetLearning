using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.UserDefineException
{
    internal class InvalidAgeException : Exception
    {
        internal InvalidAgeException(string message) : base(message){ 
            
        }
    }
}
