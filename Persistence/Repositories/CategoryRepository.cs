using Domain.Entities.Models;
using Domain.RepositoryInterfaces;
using Persistence.DataContext;
using System.Linq;

namespace Persistence.Repositories
{
    public class CategoryRepository: RepositoryBase<Category> ,ICategoryRepository
    {
        public CategoryRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
                
        }

        public IEnumerable<Category> GetAllGategories(bool trackChanges) =>
             GetAll(trackChanges)
            .OrderBy(x => x.Name)
            .ToList();
        
    }
}
