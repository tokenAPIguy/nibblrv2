using AutoMapper;
using Nibblr;
using Nibblr.DTOs;
using NuGet.Protocol.Core.Types;
using Server.Repositories;
using Server.Services.Logging;

namespace Server.Services;

public class RecipeService(IRecipeRepository recipeRepository, IMapper mapper) : IRecipeService {
    private readonly Logger logger = Logger.Default;
    
    public async Task<IEnumerable<RecipeDTO>> GetAllRecipes() {
        IEnumerable<Recipe> recipes = await recipeRepository.GetAllAsync();
        return mapper.Map<IEnumerable<RecipeDTO>>(recipes);
    }

    public async Task<RecipeDTO?> GetRecipeById(int id) {
        Recipe? recipe = await recipeRepository.GetByIdAsync(id);
        return mapper.Map<RecipeDTO>(recipe);
    }

    public void ValidateRecipe(Recipe recipe) { }
}