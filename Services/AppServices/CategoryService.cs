using Domain.Entities.Models;
using Domain.RepositoryInterfaces;
using Service.Abstractions;

namespace Shared.AppServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        public CategoryService(IRepositoryManager repositoryManager,
           ILoggerManager loggerManager)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager; 
        }

        public IEnumerable<Category> GetAllCategories(bool trackChanges)
        {
            try
            {
                var categories =
                _repositoryManager.CategoryRepository.GetAllCategories(trackChanges);
                return categories;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the{nameof(GetAllCategories)} service method {ex}");
                throw;
            }
        }
    }
}
