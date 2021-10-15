using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoyalRecipe.Core.Domain.Receipes;

namespace RoyalRecipe.Infrastructures.Data.Sql.Receipes
{
    public class RecipeImageConfiguration : IEntityTypeConfiguration<RecipeImage>
    {
        public void Configure(EntityTypeBuilder<RecipeImage> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
            builder.Property(c => c.PhysicalPath).HasMaxLength(500).IsRequired();
            builder.Property(c => c.FileType).HasMaxLength(10).IsRequired();
        }
    }
}
