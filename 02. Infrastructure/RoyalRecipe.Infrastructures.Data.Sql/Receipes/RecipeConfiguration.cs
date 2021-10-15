using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoyalRecipe.Core.Domain.Receipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalRecipe.Infrastructures.Data.Sql.Receipes
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.Property(c => c.Title).HasMaxLength(100).IsRequired();
            builder.Property(c=>c.ShortDescription).HasMaxLength(500).IsRequired();
            builder.Property(c=>c.Detail).IsRequired();
            builder.OwnsMany(c => c.Ingredients);
        }
    }
}
