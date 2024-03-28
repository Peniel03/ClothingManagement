using Domain.Entities.Models;

namespace Service.Abstractions 
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories(bool trackChanges);
    }
}
