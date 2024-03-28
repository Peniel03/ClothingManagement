using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
    /// <summary>
    /// configuration for the clothe model
    /// </summary>
    public class ClotheConfiguration : IEntityTypeConfiguration<Clothe>
    {
        /// <summary>
        /// method to configure the clothe model
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Clothe> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired(true);

            builder.HasMany(x => x.Likes)
                   .WithOne(x => x.Clothe)
                   .HasForeignKey(x => x.ClotheId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Comments)
                   .WithOne(x => x.Clothe)
                   .HasForeignKey(x => x.ClotheId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Clothes");
        }
    }
}
