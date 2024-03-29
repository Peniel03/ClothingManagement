using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Exceptions.AlreadyExist
{
    public sealed class ClotheAlreadyExistException: AlreadyExistException
    {
        public ClotheAlreadyExistException(string clotheName)
            :base($"The clothe with the nmae : {clotheName} Already exist in the database") 
        {
                
        }
    }
}
