using Domain.Entities.Models;
using Domain.RepositoryInterfaces;
using Persistence.DataContext;

namespace Persistence.Repositories
{
    public class LikeRepository:  RepositoryBase<Like>, ILikeRepository
    {
        public LikeRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
                
        }

        public IEnumerable<Like> GetAllLikes(bool trackChanges) =>
               GetAll(trackChanges)
                     .OrderBy(x => x.CreationDateTime)
                     .ToList();
     }
}
