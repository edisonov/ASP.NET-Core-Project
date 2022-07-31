using Recipe.Data.Common.Models;

namespace Recipe.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Recipes = new HashSet<Recipe>();
        }

        public string Name { get; set; }

        public ICollection<Recipe> Recipes { get; set; }
    }
}
