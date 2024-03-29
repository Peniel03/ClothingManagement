using Domain.Entities.Models;
using Domain.RepositoryInterfaces;
using Persistence.DataContext;

namespace Persistence.Repositories
{
    public class CollectionRepository: RepositoryBase<Collection>, ICollectionRepository
    {
        public CollectionRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
                
        }

        public IEnumerable<Collection> GetAllCollections(bool trackChanges) =>
             GetAll(trackChanges)
            .OrderBy(x => x.Name)
            .ToList();

    }
}
