using RoyalRecipe.Core.Domain.Tags;
using RoyalRecipe.Infrastructures.Data.Sql.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RoyalRecipe.Infrastructures.Data.Sql.Tags
{
    public class TagRepository : EfRepository<Tag>, ITagRepository
    {
        public TagRepository(RoyalRecipeDbContext royalRecipeDbContext) : base(royalRecipeDbContext)
        {
        }
    }
}
