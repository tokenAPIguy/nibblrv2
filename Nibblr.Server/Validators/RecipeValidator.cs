using FluentValidation;
using Shared.Models;

namespace Server.Validators;

public class RecipeValidator : AbstractValidator<Recipe> {
    public RecipeValidator() {
        RuleFor(x => x.ID).NotEmpty();
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(50);
        
        RuleFor(x => x.Category).NotEmpty();
        RuleFor(x => x.Description).Length(1, 150);
        RuleFor(x => x.Bookmarked).NotNull();

        RuleFor(x => x.Servings).GreaterThan(0);
        RuleFor(x => x.Calories).InclusiveBetween(0, 10000);
        RuleFor(x => x.Carbs).InclusiveBetween(0, 1000);
        RuleFor(x => x.Fat).InclusiveBetween(0, 1000);
        RuleFor(x => x.Protein).InclusiveBetween(0, 1000);

    }
    //TODO add validation for ingredients? 

}