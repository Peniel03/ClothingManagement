﻿using Domain.Entities.Models;

namespace Domain.RepositoryInterfaces
{
    public interface ICollectionRepository
    {
        IEnumerable<Collection> GetAllCollections(bool trackChanges);
    }
}
