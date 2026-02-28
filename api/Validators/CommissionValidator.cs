using AvalphaTechnologies.CommissionCalculator.Models;

namespace AvalphaTechnologies.CommissionCalculator.Validators
{
    public static class CommissionValidator
    {
        private const int MaxSalesLimit = 1_000_000;
        private const decimal MaxAmountLimit = 1_000_000m;

        public static (bool IsValid, string ErrorMessage) Validate(CommissionCalculationRequest request)
        {
            if (request == null)
                return (false, "Request cannot be null.");

            if (request.LocalSalesCount < 0)
                return (false, "Local sales count cannot be negative.");

            if (request.ForeignSalesCount < 0)
                return (false, "Foreign sales count cannot be negative.");

            if (request.AverageSaleAmount < 0)
                return (false, "Average sale amount cannot be negative.");

            if (request.LocalSalesCount > MaxSalesLimit ||
                request.ForeignSalesCount > MaxSalesLimit)
                return (false, "Sales count exceeds allowed limit.");

            if (request.AverageSaleAmount > MaxAmountLimit)
                return (false, "Average sale amount exceeds allowed limit.");

            return (true, string.Empty);
        }
    }
}