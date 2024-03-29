using Domain.Entities.Models;
using Shared.DTOs;

namespace Service.Abstractions
{
    public interface IUserService
    {
        public IEnumerable<UserReadDto> GetAllUsers(CancellationToken cancellationToken);
        //Task<bool> CreateUserAsync(UserDto user, string password);
    }
}  
