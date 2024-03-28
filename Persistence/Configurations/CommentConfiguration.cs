using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    /// <summary>
    /// configuration for the comment model
    /// </summary>
    public class CommentConfiguration: IEntityTypeConfiguration<Comment>
    {
        /// <summary>
        /// method to configure the comment model 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreationDateTime).IsRequired(true);

            builder.ToTable("Comments");
        }
    }
}
