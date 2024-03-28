using Domain.Entities.Models;

namespace Domain.RepositoryInterfaces
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAllComment(bool trackChanges);
    }
}

