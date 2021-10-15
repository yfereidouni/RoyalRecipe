using RoyalRecipe.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalRecipe.Core.Domain.Receipes
{
    public class RecipeImage : Entity
    {
        public string Name { get; set; }
        public string PhysicalPath { get; set; }
        public string FileType { get; set; }
    }
}
