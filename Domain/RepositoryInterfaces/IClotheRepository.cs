using Domain.Entities.Models;

namespace Domain.RepositoryInterfaces
{
    public interface IClotheRepository
    {
        IEnumerable<Clothe> GetAllClothes(bool trackChanges);
    }
}
