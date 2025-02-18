using Microsoft.EntityFrameworkCore;
using Nibblr;
using Server.Data;

namespace Server.Repositories;

public class RecipeRepository(ApplicationDbContext dbContext) : IRecipeRepository {
    public async Task<IEnumerable<Recipe>> GetAllAsync() {
        return await dbContext.Recipes      
            .Include(x => x.Category)
            .Include(r => r.Macros)
            .ToListAsync();
    }
    public async Task<Recipe?> GetByIdAsync(int id) {
        return await dbContext.Recipes            
            .Include(x => x.Category)
            .Include(r => r.Instructions)
            .Include(r => r.Ingredients)
            .Include(r => r.Macros)
            .FirstOrDefaultAsync(x => x.ID == id);
    }
    public async Task AddAsync(Recipe recipe) {
        dbContext.Recipes.Add(recipe);
        await dbContext.SaveChangesAsync();
    }
    public async Task UpdateAsync(Recipe recipe) {
        dbContext.Recipes.Update(recipe);
        // dbContext.Entry(entity).State = EntityState.Modified;
        await dbContext.SaveChangesAsync();    
    }
    public async Task RemoveAsync(Recipe recipe) {
        dbContext.Recipes.Remove(recipe);
        await dbContext.SaveChangesAsync();
    }
}