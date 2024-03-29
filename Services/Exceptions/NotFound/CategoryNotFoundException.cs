using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Exceptions.NotFound
{
    public sealed class CategoryNotFoundException: NotFoundException
    {
        public CategoryNotFoundException(string categoryId)
            :base($"The category with id: {categoryId} doesn't exist in the dtabase")
        {
                
        }
    }
}
