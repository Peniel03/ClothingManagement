using Domain.Entities.Models;

namespace Service.Abstractions
{
    public interface IClotheService
    {
        IEnumerable<Clothe> GetAllClothes(bool trackChanges);
    } 
}
