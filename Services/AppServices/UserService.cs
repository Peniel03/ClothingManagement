using AutoMapper;
using Domain.Entities.Models;
using Domain.RepositoryInterfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Service.Abstractions;
using Shared.DTOs;

namespace Shared.AppServices
{
    public class UserService : IUserService
    {
         private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
         private readonly ILoggerManager _loggerManager;
        public UserService(IMapper mapper,
            UserManager<User> userManager,
             ILoggerManager loggerManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _loggerManager = loggerManager;

        }

        public IEnumerable<UserReadDto> GetAllUsers(CancellationToken cancellationToken)
        {
             
            try
            {
                var users = _userManager.Users.ToListAsync(cancellationToken); 

                var usersDto = _mapper.Map<List<UserReadDto>>(users);
                return usersDto;
            }
            catch (Exception ex)
            {
                 _loggerManager.LogError($"Something went wrong in the{ nameof(GetAllUsers)} service method {ex}");
                 throw;
            }
        }
    }
}
