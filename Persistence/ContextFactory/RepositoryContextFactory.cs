using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Persistence.DataContext;
        

namespace Persistence.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var optionsbuilder = new DbContextOptionsBuilder<RepositoryContext>()
            .UseNpgsql(builder.GetConnectionString("DefaultConnection"));

            return new RepositoryContext(optionsbuilder.Options); 
        }
    }
}
