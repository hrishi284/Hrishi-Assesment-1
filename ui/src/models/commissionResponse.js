export const commissionResponse = (apiResponse) => ({
  avalphaTechnologiesCommission: apiResponse.avalphaTechnologiesCommissionAmount,
  competitorCommission: apiResponse.competitorCommissionAmount
});