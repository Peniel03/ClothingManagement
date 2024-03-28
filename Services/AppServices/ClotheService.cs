using Domain.RepositoryInterfaces;
using Service.Abstractions;

namespace Services.AppServices
{
    public class ClotheService:IClotheService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        public ClotheService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
        }  
    }
}
