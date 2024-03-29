using Domain.Entities.Models;
using Domain.RepositoryInterfaces;
using Service.Abstractions;

namespace Shared.AppServices
{
    public class CollectionService: ICollectionService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        public CollectionService(IRepositoryManager repositoryManager,
          ILoggerManager loggerManager)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;  
        }

        public IEnumerable<Collection> GetAllCollections(bool trackChanges)
        {
            try
            {
                var collections =
                _repositoryManager.CollectionRepository.GetAllCollections(trackChanges);
                return collections;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the{nameof(GetAllCollections)} service method {ex}"); 
                throw;
            }
        }
    }
}
