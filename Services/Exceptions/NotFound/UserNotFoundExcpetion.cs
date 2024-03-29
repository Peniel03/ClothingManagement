using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Exceptions.NotFound
{
    public sealed class UserNotFoundExcpetion: NotFoundException
    {
        public UserNotFoundExcpetion(string userEmail)
            :base($"The user with email: {userEmail} doesn't exist in the database")
        {
            
        }
    }
}
