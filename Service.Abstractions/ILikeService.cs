using Domain.Entities.Models;

namespace Service.Abstractions
{
    public interface ILikeService
    {
        IEnumerable<Like> GetAllLikes(bool trackChanges); 
    }
}
