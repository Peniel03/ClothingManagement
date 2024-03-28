using Domain.RepositoryInterfaces;
using Service.Abstractions;

namespace Services.AppServices
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
    }
}
