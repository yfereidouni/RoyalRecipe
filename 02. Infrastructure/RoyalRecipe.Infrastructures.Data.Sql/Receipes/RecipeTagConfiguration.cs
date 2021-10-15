using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoyalRecipe.Core.Domain.Receipes;
using RoyalRecipe.Core.Domain.Tags;

namespace RoyalRecipe.Infrastructures.Data.Sql.Receipes
{
    public class RecipeTagConfiguration : IEntityTypeConfiguration<RecipeTag>
    {
        public void Configure(EntityTypeBuilder<RecipeTag> builder)
        {
            builder.HasKey(c => new { c.RecipeId, c.TagId });
            builder.HasOne<Recipe>().WithMany(c => c.RecipeTags).HasForeignKey(c => c.RecipeId);
            builder.HasOne<Tag>().WithMany().HasForeignKey(c => c.TagId);
        }
    }
}
