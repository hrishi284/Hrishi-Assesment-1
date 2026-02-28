using AvalphaTechnologies.CommissionCalculator.Models;

namespace AvalphaTechnologies.CommissionCalculator.Services.Interfaces
{
    public interface ICommissionService
    {
        CommissionCalculationResponse Calculate(CommissionCalculationRequest request);
    }
}