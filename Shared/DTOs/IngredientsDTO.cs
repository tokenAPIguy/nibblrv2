namespace Shared.DTOs;

public class IngredientsDTO {
    public string Name { get; set; }
    public double? Quantity { get; set; }
    public double? Weight { get; set; }
    public string? WeightUnit { get; set; }
    public string? Description { get; set; }
}