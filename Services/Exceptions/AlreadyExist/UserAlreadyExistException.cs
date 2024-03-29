using Domain.Exceptions;
using Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Exceptions.AlreadyExist
{
    public sealed class UserAlreadyExistException: AlreadyExistException
    {
        public UserAlreadyExistException(string email) 
            :base ($"The user with email: {email} already exist in the database")
        { 

        }
    }
}
