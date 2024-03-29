using Domain.Entities.Models;
using Domain.RepositoryInterfaces;
using Service.Abstractions;

namespace Shared.AppServices
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

        public IEnumerable<Like> GetAllLikes(bool trackChanges)
        {
            try
            {
                var likes =
                _repositoryManager.LikeRepository.GetAllLikes(trackChanges);
                return likes;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the{nameof(GetAllLikes)} service method {ex}");
                throw;
            }
        }
    }
}
