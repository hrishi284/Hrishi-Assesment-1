using AvalphaTechnologies.CommissionCalculator.Models;
using AvalphaTechnologies.CommissionCalculator.Services.Interfaces;

namespace AvalphaTechnologies.CommissionCalculator.Services.Services
{
    public class CommissionService : ICommissionService
    {
        private const decimal AvalphaLocalRate = 0.20m;
        private const decimal AvalphaForeignRate = 0.35m;

        private const decimal CompetitorLocalRate = 0.02m;
        private const decimal CompetitorForeignRate = 0.0755m;

        public CommissionCalculationResponse Calculate(CommissionCalculationRequest request)
        {
            var avalphaLocal = request.LocalSalesCount *
                               request.AverageSaleAmount *
                               AvalphaLocalRate;

            var avalphaForeign = request.ForeignSalesCount *
                                 request.AverageSaleAmount *
                                 AvalphaForeignRate;

            var competitorLocal = request.LocalSalesCount *
                                  request.AverageSaleAmount *
                                  CompetitorLocalRate;

            var competitorForeign = request.ForeignSalesCount *
                                    request.AverageSaleAmount *
                                    CompetitorForeignRate;

            return new CommissionCalculationResponse
            {
                AvalphaTechnologiesCommissionAmount = decimal.Round(avalphaLocal + avalphaForeign, 2),
                CompetitorCommissionAmount = decimal.Round(competitorLocal + competitorForeign, 2)
            };
        }
    }
}