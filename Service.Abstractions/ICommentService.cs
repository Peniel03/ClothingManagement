using Domain.Entities.Models;

namespace Service.Abstractions
{
    public interface ICommentService
    {
        IEnumerable<Comment> GetAllComments(bool trackChanges); 
    } 
}
