using ChefByStep.API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChefByStep.API.Repos
{
    public class UserRepo : GenericRepo<User>, IUserRepo
    {
        public UserRepo(DatabaseContext context) : base(context)
        {
        }

        public override async Task<User> GetAsync(int id)
        {
            return await _context.Users
                .Include(x => x.CompletedRecipes)
                .ThenInclude(x => x.Recipe)
                .Include(x => x.Ratings)
                .Include(x => x.FavouriteRecipes)
                .Include(x => x.CompletedRecipes)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public override async Task<List<User>> GetAllAsync()
        {
            return await _context.Users
                .Include(x => x.CompletedRecipes)
                .ThenInclude(x => x.Recipe)
                .Include(x => x.Ratings)
                .Include(x => x.FavouriteRecipes)
                .Include(x => x.CompletedRecipes)
                .ToListAsync();
        }
    }
}