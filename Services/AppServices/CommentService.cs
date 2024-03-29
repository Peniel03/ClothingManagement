using Domain.Entities.Models;
using Domain.RepositoryInterfaces;
using Service.Abstractions;

namespace Shared.AppServices
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

        public IEnumerable<Comment> GetAllComments(bool trackChanges)
        {
            try
            {
                var comments =
                _repositoryManager.CommentRepository.GetAllComments(trackChanges);
                return comments;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the{nameof(GetAllComments)} service method {ex}");
                throw; 
            }
        }
    }
}
