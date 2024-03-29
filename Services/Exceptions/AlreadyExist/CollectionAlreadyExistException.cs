using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Exceptions.AlreadyExist
{
    public sealed class CollectionAlreadyExistException: AlreadyExistException
    {
        public CollectionAlreadyExistException(string collectionName)
            :base($"The collection with the name: {collectionName} already exist in the database")
        {
                
        }
    }
}
