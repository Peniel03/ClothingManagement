using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public abstract class AlreadyExistException: Exception
    {
        protected AlreadyExistException(string message)
            :base(message)
        {
            
        }
    }
}
