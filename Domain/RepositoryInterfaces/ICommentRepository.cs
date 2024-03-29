using Domain.Entities.Models;

namespace Domain.RepositoryInterfaces
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAllComments(bool trackChanges);
    }
}

