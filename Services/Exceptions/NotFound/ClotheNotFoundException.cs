using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Exceptions.NotFound
{
    public sealed class ClotheNotFoundException : NotFoundException
    {
        public ClotheNotFoundException(string clotheId)
            : base($"The clothe with id: {clotheId} desn't exist in the databse")
        {
                
        }
    }
}
