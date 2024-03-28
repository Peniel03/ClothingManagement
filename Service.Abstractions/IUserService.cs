using Domain.Entities.Models;

namespace Service.Abstractions
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers(bool trackChanges);
        Task<bool> CreateUserAsync(UserDto user, string password);
    }
}  
