using Domain.RepositoryInterfaces;
using Service.Abstractions;

namespace Services.AppServices
{
    public class LikeService: ILikeService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        public LikeService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager; 
        }
    }
}
