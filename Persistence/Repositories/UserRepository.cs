using Domain.Entities.Models;
using Domain.RepositoryInterfaces;
using Persistence.DataContext;

namespace Persistence.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
                
        }
    }
}
