using ChefByStep.API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChefByStep.API.Repos
{
    public class RecipeRepo : GenericRepo<Recipe>, IRecipeRepo
    {
        public RecipeRepo(DatabaseContext context) : base(context)
        {
        }

        public override Task<Recipe> GetAsync(int id)
        {
            return _context.Recipes
                .Include(x => x.Ratings)
                .Include(x => x.Steps)
                .Include(x => x.Ingredients)
                    .ThenInclude(x => x.Ingredient)
                .Include(x => x.FavouritedBy)
                .Include(x => x.CompletedBy)
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public override Task<List<Recipe>> GetAllAsync()
        {
            return _context.Recipes
                .Include(x => x.Ratings)
                .Include(x => x.Steps)
                .Include(x => x.Ingredients)
                    .ThenInclude(x => x.Ingredient)
                .Include(x => x.FavouritedBy)
                .Include(x => x.CompletedBy)
                .Include(x => x.User)
                .ToListAsync();
        }
    }
}