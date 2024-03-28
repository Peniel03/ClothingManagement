using AutoMapper;
using Domain.Entities.Models;
using Domain.RepositoryInterfaces;
using Microsoft.AspNetCore.Identity;
using Service.Abstractions;

namespace Services.AppServices
{
    public class UserService : IUserService
    {
        //private readonly IMapper _mapper;
        //private readonly UserManager<User> _userManager;
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        public UserService(//IMapper mapper,
            //UserManager<User> userManager,
            IRepositoryManager repositoryManager,
            ILoggerManager loggerManager)
        {
            //_mapper = mapper;
          //  _userManager = userManager;
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;

        }

        public IEnumerable<User> GetAllUsers(bool trackChanges)
        {
            try
            {
                var users =
                _repositoryManager.UserRepository.(trackChanges);
                return users;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the 
            { nameof(GetAllCompanies)}
                service method { ex}
                ");
            throw;
            }
        }
    }
}
