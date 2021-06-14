using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChefByStep.API.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Recipe> CreatedRecipes { get; set; }
        public List<FavouritedRecipe> FavouriteRecipes { get; set; }
        public List<CompletedRecipe> CompletedRecipes { get; set; }
        public List<RecipeRating> Ratings { get; set; }
    }
}