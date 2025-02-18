using Nibblr;
using Nibblr.DTOs;

namespace Server.Services;

public interface IRecipeService {
    public Task<IEnumerable<RecipeDTO>> GetAllRecipes();
    public Task<RecipeDTO?> GetRecipeById(int id); 
    void ValidateRecipe(Recipe recipe);
}