using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    /// <summary>
    /// configuration for the collection model 
    /// </summary>
    public class CollectionConfiguration : IEntityTypeConfiguration<Collection>
    {
        /// <summary>
        /// method to configure the collection model
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Collection> builder) 
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Description).IsRequired(true);
            builder.Property(x => x.Tag).IsRequired(true);

            builder.HasMany(x => x.Clothes)
                   .WithOne(x => x.Collection)
                   .HasForeignKey(x => x.CollectionId) 
                   .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Collections");
        }
    }
}
