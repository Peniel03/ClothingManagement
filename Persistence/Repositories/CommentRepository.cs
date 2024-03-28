using Domain.Entities.Models;
using Domain.RepositoryInterfaces;
using Persistence.DataContext;

namespace Persistence.Repositories
{
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
                
        }

        public IEnumerable<Comment> GetAllComment(bool trackChanges) =>
         GetAll(trackChanges)
        .OrderBy(x => x.CreationDateTime)
        .ToList();
    }
}
