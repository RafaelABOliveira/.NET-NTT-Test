using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct;

/// <summary>
/// Validator for CreateProductCommand that defines validation rules for product creation command.
/// </summary>
public class CreateProductValidator : AbstractValidator<CreateProductCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateProductCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Title: Required, must be between 3 and 100 characters
    /// - Price: Must be greater than zero
    /// - Description: Required, must be between 10 and 500 characters
    /// - Category: Required
    /// - Image: Must be a valid URL
    /// - Rating: Rate must be between 0 and 5, Count must be non-negative
    /// </remarks>
    public CreateProductValidator()
    {
        RuleFor(product => product.Title).NotEmpty().Length(3, 100);
        RuleFor(product => product.Price).GreaterThan(0);
        RuleFor(product => product.Description).NotEmpty().Length(10, 500);
        RuleFor(product => product.Category).NotEmpty();
        RuleFor(product => product.Rating.Rate).InclusiveBetween(0, 5);
        RuleFor(product => product.Rating.Count).GreaterThanOrEqualTo(0);
    }
}
