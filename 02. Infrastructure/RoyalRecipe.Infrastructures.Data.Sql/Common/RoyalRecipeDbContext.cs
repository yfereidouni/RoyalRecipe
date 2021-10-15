using Microsoft.EntityFrameworkCore;
using RoyalRecipe.Core.Domain.Receipes;
using RoyalRecipe.Core.Domain.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalRecipe.Infrastructures.Data.Sql.Common
{
    public class RoyalRecipeDbContext : DbContext
    {
        public RoyalRecipeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeImage> RecipeImages { get; set; }
        public DbSet<RecipeTag> RecipeTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RoyalRecipeDbContext).Assembly);
        }

    }
}
