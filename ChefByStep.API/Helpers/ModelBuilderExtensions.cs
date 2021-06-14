using ChefByStep.API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ChefByStep.API.Helpers
{
    public static class ModelBuilderExtensions
    {
        public static void BuildRelations(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompletedRecipe>()
                .HasKey(x => new { x.RecipeId, x.UserId });
            modelBuilder.Entity<FavouritedRecipe>()
                .HasKey(x => new { x.RecipeId, x.UserId });
            modelBuilder.Entity<RecipeIngredient>()
                .HasKey(x => new { x.RecipeId, x.IngredientId });
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            BuildRecipes(modelBuilder);
            BuildIngredients(modelBuilder);
            BuildRecipeIngredients(modelBuilder);
        }

        private static void BuildRecipes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Pasta Bolognese",
                    Description = "Spaghetti bolognese consists of spaghetti (long strings of pasta) with an Italian ragù (meat sauce) made with minced beef, bacon and tomatoes, served with Parmesan cheese. Spaghetti bolognese is one of the most popular pasta dishes eaten outside of Italy.",
                    ImageUrl = "https://www.kitchensanctuary.com/wp-content/uploads/2019/09/Spaghetti-Bolognese-square-FS-0204.jpg"
                },
                new Recipe
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Chili Con Carne",
                    Description = "This great chilli recipe has to be one of the best dishes to serve to friends for a casual get-together. An easy sharing favourite that uses up storecupboard ingredients.",
                    ImageUrl = "https://www.kitchensanctuary.com/wp-content/uploads/2014/10/Chilli-Con-Carne-Recipe-tall-FS.jpg"
                },
                new Recipe
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Kung Pao Chicken",
                    Description = "Rustle up this prawn and cauliflower stir fry in just 25 minutes. You can easily make it vegan if preferred – simply omit the prawns and double up on the veg.",
                    ImageUrl = "https://www.kitchensanctuary.com/wp-content/uploads/2019/10/Kung-Pao-Chicken-tall-56-new.jpg"
                }
                );
        }

        private static void BuildIngredients(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { Id = 1, Name = "Onion" },
                new Ingredient { Id = 2, Name = "Vegetable Oil" },
                new Ingredient { Id = 3, Name = "Garlic" },
                new Ingredient { Id = 4, Name = "Red Chili" },
                new Ingredient { Id = 5, Name = "Brown Rice" },
                new Ingredient { Id = 6, Name = "Paprika" },
                new Ingredient { Id = 7, Name = "Rep Pepper" },
                new Ingredient { Id = 8, Name = "Minced Beef" },
                new Ingredient { Id = 9, Name = "Red Beans" },
                new Ingredient { Id = 10, Name = "Tomato Purée" },
                new Ingredient { Id = 11, Name = "Carrot" },
                new Ingredient { Id = 12, Name = "Oregano" },
                new Ingredient { Id = 13, Name = "Speghetti" },
                new Ingredient { Id = 14, Name = "Parmesan" }
                );
        }

        private static void BuildRecipeIngredients(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredient>().HasData(
                new RecipeIngredient { RecipeId = 1, IngredientId = 14 },
                new RecipeIngredient { RecipeId = 1, IngredientId = 13 },
                new RecipeIngredient { RecipeId = 1, IngredientId = 12 },
                new RecipeIngredient { RecipeId = 1, IngredientId = 11 },
                new RecipeIngredient { RecipeId = 1, IngredientId = 8 },
                new RecipeIngredient { RecipeId = 2, IngredientId = 4 },
                new RecipeIngredient { RecipeId = 2, IngredientId = 8 },
                new RecipeIngredient { RecipeId = 2, IngredientId = 10 },
                new RecipeIngredient { RecipeId = 2, IngredientId = 9 },
                new RecipeIngredient { RecipeId = 3, IngredientId = 1 },
                new RecipeIngredient { RecipeId = 3, IngredientId = 2 },
                new RecipeIngredient { RecipeId = 3, IngredientId = 3 }
                );
        }
    }
}