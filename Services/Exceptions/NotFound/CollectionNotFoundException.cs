using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Exceptions.NotFound
{
    public sealed class CollectionNotFoundException : NotFoundException
    {
        public CollectionNotFoundException(string collectionId)
            :base ($"The collection with id: {collectionId} doesn't exist in the database")
        {
                
        }
    }
}
