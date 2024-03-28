using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IRepositoryManager
    {
        IUserRepository UserRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IClotheRepository ClothesRepository { get; }
        ICollectionRepository CollectionRepository { get; }
        ICommentRepository CommentRepository { get; }
        ILikeRepository LikeRepository { get; }
        void Save(); 
    }
}
