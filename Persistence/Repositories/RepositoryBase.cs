using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;
using System;
using System.Linq.Expressions;

namespace Persistence.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext _repositoryContext;
        public RepositoryBase(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public void Create(T entity) => _repositoryContext.Set<T>().Add(entity);
        public void Delete(T entity) => _repositoryContext.Set<T>().Remove(entity);

        public IQueryable<T> GetAll(bool trackChanges) =>
            !trackChanges ?
               _repositoryContext.Set<T>()
                 .AsNoTracking() :
               _repositoryContext.Set<T>();
        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, 
            bool trackChanges) =>
            !trackChanges ?
               _repositoryContext.Set<T>()
                   .Where(expression)
                   .AsNoTracking() :
               _repositoryContext.Set<T>()
                   .Where(expression);
        public void Update(T entity) => _repositoryContext.Set<T>().Update(entity);
    }
}
