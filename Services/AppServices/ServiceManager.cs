using Domain.RepositoryInterfaces;
using Service.Abstractions;

namespace Services.AppServices
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<ICategoryService> _categoryService;
        private readonly Lazy<ICollectionService> _collectionService;
        private readonly Lazy<IClotheService> _clotheService;
        private readonly Lazy<ILikeService> _likeService;
        private readonly Lazy<ICommentService> _commentService;

        public ServiceManager(IRepositoryManager repositoryManager, 
            ILoggerManager loggerManager)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager,loggerManager));
            _categoryService = new Lazy<ICategoryService>(() => new CategoryService(repositoryManager, loggerManager));
            _collectionService = new Lazy<ICollectionService>(() => new CollectionService(repositoryManager, loggerManager));
            _clotheService = new Lazy<IClotheService>(() => new ClotheService(repositoryManager, loggerManager));
            _likeService = new Lazy<ILikeService>(() => new LikeService(repositoryManager, loggerManager));
            _commentService = new Lazy<ICommentService>(() => new CommentService(repositoryManager, loggerManager));
        }
        public IUserService UserService => _userService.Value;
        public IClotheService ClotheService => _clotheService.Value;
        public ICategoryService CategoryService => _categoryService.Value;
        public ICollectionService CollectionService => _collectionService.Value;
        public ICommentService CommentService => _commentService.Value;
        public ILikeService LikeService => _likeService.Value; 
    }
}
