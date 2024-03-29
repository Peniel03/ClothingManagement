using Domain.RepositoryInterfaces;
using Persistence.DataContext;

namespace Persistence.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICollectionRepository> _collectionRepository;
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<IClotheRepository> _clotheRepository;
        private readonly Lazy<ILikeRepository> _likeRepository;
        private readonly Lazy<ICommentRepository> _commentRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _collectionRepository = new Lazy<ICollectionRepository>(() => new CollectionRepository(repositoryContext));
            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(repositoryContext));
            _clotheRepository = new Lazy<IClotheRepository>(() => new ClotheRepository(repositoryContext));
            _likeRepository = new Lazy<ILikeRepository>(() => new LikeRepository(repositoryContext));
            _commentRepository = new Lazy<ICommentRepository>(() => new CommentRepository(repositoryContext));
        }

        public ICategoryRepository CategoryRepository => _categoryRepository.Value;
        public IClotheRepository ClotheRepository => _clotheRepository.Value;
        public ICollectionRepository CollectionRepository => _collectionRepository.Value;
        public ICommentRepository CommentRepository => _commentRepository.Value;
        public ILikeRepository LikeRepository => _likeRepository.Value;
        public  void Save() => _repositoryContext.SaveChanges();
    }
}
