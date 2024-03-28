using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstractions
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
        IClotheService ClotheService { get; }
        ICategoryService CategoryService { get; }
        ICollectionService CollectionService { get;} 
        ICommentService CommentService { get; }
        ILikeService LikeService { get; } 
    }
}
