using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.SaleItems;

/// <summary>
/// Validator for CreateSaleItemRequest.
/// </summary>
public class CreateSaleItemRequestValidator : AbstractValidator<CreateSaleItemRequest>
{
    public CreateSaleItemRequestValidator()
    {
        RuleFor(x => x.Quantity)
            .GreaterThan(0).WithMessage("Quantity must be greater than zero.")
            .LessThanOrEqualTo(20).WithMessage("Cannot sell more than 20 identical items.");

        RuleFor(x => x.Discount).Equal(0).When(x => x.Quantity < 4)
            .WithMessage("Purchases below 4 items cannot have a discount.");

        RuleFor(x => x.Discount).Equal(0.10m).When(x => x.Quantity >= 4 && x.Quantity < 10)
            .WithMessage("Purchases between 4 and 9 identical items have a 10% discount.");

        RuleFor(x => x.Discount).Equal(0.20m).When(x => x.Quantity >= 10 && x.Quantity <= 20)
            .WithMessage("Purchases between 10 and 20 identical items have a 20% discount.");
    }
}
