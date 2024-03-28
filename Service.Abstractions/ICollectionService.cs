using Domain.Entities.Models;

namespace Service.Abstractions
{
    public interface ICollectionService
    {
        IEnumerable<Collection> GetAllCollections(bool trackChanges);
    }  
}
