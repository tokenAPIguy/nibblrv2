using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Newtonsoft.Json;
using Nibblr;
using Nibblr.DTOs;
using Server.Data;
using Server.Repositories;
using Server.Services;

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipeController(IRecipeService _recipeService) : ControllerBase {
    
    [HttpGet("/api/recipes")]
    public async Task<IResult> GetAllRecipes() {
        return Results.Ok(await _recipeService.GetAllRecipes());
    }

    [HttpGet("/api/recipes/{id:int}")]
    public async Task<IResult> GetRecipeById(int id) {
        RecipeDTO? recipe = await _recipeService.GetRecipeById(id);
        return recipe != null 
            ? Results.Ok(recipe)
            : Results.NotFound();
    }
}