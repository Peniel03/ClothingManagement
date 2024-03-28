using Domain.Entities.Models;
using Domain.RepositoryInterfaces;
using Persistence.DataContext;

namespace Persistence.Repositories
{
    public class ClotheRepository: RepositoryBase<Clothe> ,IClotheRepository
    {
        public ClotheRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
                
        }

        public IEnumerable<Clothe> GetAllClothes(bool trackChanges) =>
                GetAll(trackChanges)
                   .OrderBy(x => x.Name)
                   .ToList();
    }
}
