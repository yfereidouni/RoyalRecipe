using RoyalRecipe.Core.Domain.Common;
using RoyalRecipe.Core.Domain.Tags;
using System;

namespace RoyalRecipe.Core.Domain.Receipes
{
    public class RecipeTag : Entity
    {
        public Guid RecipeId { get; set; }
        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
