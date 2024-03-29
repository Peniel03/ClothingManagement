using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Exceptions.NotFound
{
    public sealed class CommentNotFoundException : NotFoundException
    {
        public CommentNotFoundException(string commentId)
            :base($"The comment with id: {commentId} doesn't exist in the database")
        {
                
        }
    }
}
