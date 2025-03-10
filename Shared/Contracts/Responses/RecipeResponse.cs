using Shared.Models;

namespace Shared.Contracts.Responses;

public class RecipeResponse {
    public required int ID { get; init; }
    public required string Name { get; init; }
    public required string? Description { get; init; }
    public required string? URL { get; init; }
    public required int Servings { get; init; }
    public required int Calories { get; init; }
    public required double Fat { get; init; }
    public required double Carbs { get; init; }
    public required double Protein { get; init; }
    public ICollection<Tag> Tags { get; set; } = [];

    public required ICollection<Ingredients> Ingredients { get; init; } = [];
    public required ICollection<Instructions> Instructions { get; init; } = [];
    public required bool Bookmarked { get; init; }
}