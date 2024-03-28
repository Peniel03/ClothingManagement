using Domain.Entities.Models;

namespace Domain.RepositoryInterfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllGategories(bool trackChanges);
    }
}
