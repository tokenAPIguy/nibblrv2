using AutoMapper;
using Nibblr;
using Nibblr.DTOs;

namespace Server.Services;

public class MappingProfile : Profile {
    public MappingProfile() {
        CreateMap<Recipe, RecipeDTO>();
        CreateMap<Category, CategoryDTO>();
        CreateMap<Ingredients, IngredientsDTO>();
        CreateMap<Instructions, InstructionsDTO>();
        CreateMap<Macros, MacrosDTO>();
    }
}