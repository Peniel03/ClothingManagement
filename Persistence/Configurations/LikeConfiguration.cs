using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    /// <summary>
    /// configuration for the like model
    /// </summary>
    public class LikeConfiguration: IEntityTypeConfiguration<Like>
    {
        /// <summary>
        /// method to configure the like model
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreationDateTime).IsRequired(true);

            builder.ToTable("Likes");
        }
    }
}
