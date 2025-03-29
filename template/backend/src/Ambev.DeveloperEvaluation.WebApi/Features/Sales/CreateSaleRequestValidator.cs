using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales
{
    /// <summary>
    /// Validator for CreateSaleRequest.
    /// </summary>
    public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
    {
        public CreateSaleRequestValidator()
        {
            RuleFor(x => x.SaleNumber).NotEmpty().WithMessage("Sale number is required.");
            RuleFor(x => x.SaleDate).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Sale date cannot be in the future.");
            RuleFor(x => x.Customer).NotEmpty().WithMessage("Customer is required.");
            RuleFor(x => x.TotalAmount).GreaterThan(0).WithMessage("Total amount must be greater than zero.");
            RuleFor(x => x.Branch).NotEmpty().WithMessage("Branch is required.");
        }
    }
}
