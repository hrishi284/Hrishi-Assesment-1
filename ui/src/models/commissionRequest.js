export const commissionRequest = (formData) => ({
  localSalesCount: Number(formData.localSalesCount),
  foreignSalesCount: Number(formData.foreignSalesCount),
  averageSaleAmount: Number(formData.averageSaleAmount)
});

