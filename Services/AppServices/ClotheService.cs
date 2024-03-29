using Domain.Entities.Models;
using Domain.RepositoryInterfaces;
using Service.Abstractions;

namespace Shared.AppServices
{
    public class ClotheService : IClotheService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        public ClotheService(IRepositoryManager repositoryManager,
            ILoggerManager loggerManager)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
        }

        public IEnumerable<Clothe> GetAllClothes(bool trackChanges)
        {
            try
            {
                var clothes =
                _repositoryManager.ClotheRepository.GetAllClothes(trackChanges);
                return clothes;
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the{nameof(GetAllClothes)} service method {ex}");
                throw;
            }
        }
    }
}
