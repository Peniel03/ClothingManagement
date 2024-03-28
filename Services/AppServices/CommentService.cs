using Domain.RepositoryInterfaces;
using Service.Abstractions;

namespace Services.AppServices
{
    public class CommentService: ICommentService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        public CommentService(IRepositoryManager repositoryManager,
           ILoggerManager loggerManager )
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
        }
    }
}
