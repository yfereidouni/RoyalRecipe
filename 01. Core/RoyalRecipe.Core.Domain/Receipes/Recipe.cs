using RoyalRecipe.Core.Domain.Common;
using System.Collections.Generic;

namespace RoyalRecipe.Core.Domain.Receipes
{
    public class Recipe : Entity
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Detail { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public RecipeImage RecipeImage { get; set; }
        public List<RecipeTag> RecipeTags { get; set; }
    }
}
