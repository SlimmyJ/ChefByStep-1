using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChefByStep.API.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<RecipeRating> Ratings { get; set; }
        public List<RecipeIngredient> Ingredients { get; set; }
        public List<Step> Steps { get; set; }

        public List<FavouritedRecipe> FavouritedBy { get; set; }

        public List<CompletedRecipe> CompletedBy { get; set; }

        public User User { get; set; }
    }
}