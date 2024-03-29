using Domain.Exceptions;
using NLog.LayoutRenderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Exceptions.AlreadyExist
{
    public sealed class CategoryAlreadyExistException: AlreadyExistException
    {
        public CategoryAlreadyExistException(string categoryName)
            :base($"The category with name : {categoryName} already exist in the database")
        {
            
        }
    }
}
