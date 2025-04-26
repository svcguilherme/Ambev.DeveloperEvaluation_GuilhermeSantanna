using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation
{
    public class PurchaseItemValidator : AbstractValidator<PurchaseItem>
    {
        public PurchaseItemValidator()
        {
            RuleFor(purchaseItem => purchaseItem.Quantity)
                .LessThanOrEqualTo(20).WithMessage("A maximum of 20 items per product purchase is allowed!");

            RuleFor(purchaseItem => purchaseItem)
                .Must(p => ValidateDiscount(p))
                .WithMessage("Discount is allowed only for quantities greater than or equal to 4.");

            RuleFor(purchaseItem => purchaseItem)
                .Must(p => ValidateDiscountLayer(p, 4, 10, 10))
                .WithMessage("A 10% discount is allowed for quantities between 4 and 10.");

            RuleFor(purchaseItem => purchaseItem)
                .Must(p => ValidateDiscountLayer(p, 10, 20, 20))
                .WithMessage("A 20% discount is allowed for quantities between 10 and 20.");
        }

        private bool ValidateDiscountLayer(PurchaseItem purchaseItem, int minQuantity, int maxQuantity, int allowedDiscount)
        {
            if (purchaseItem.Quantity >= minQuantity && purchaseItem.Quantity < maxQuantity)
            {
                return purchaseItem.TotalDiscount <= allowedDiscount;
            }

            // If quantity is outside the range, we don't validate the discount here.
            return true;
        }

        private bool ValidateDiscount(PurchaseItem purchaseItem)
        {
            if (purchaseItem.Quantity < 4 && purchaseItem.TotalDiscount > 0)
            {
                return false;
            }
            return true;
        }
    }
}
