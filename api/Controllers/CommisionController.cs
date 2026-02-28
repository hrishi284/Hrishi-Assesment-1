using AvalphaTechnologies.CommissionCalculator.Models;
using AvalphaTechnologies.CommissionCalculator.Services.Interfaces;
using AvalphaTechnologies.CommissionCalculator.Validators;
using Microsoft.AspNetCore.Mvc;

namespace AvalphaTechnologies.CommissionCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommisionController : ControllerBase
    {
        private readonly ICommissionService _commissionService;

        public CommisionController(ICommissionService commissionService)
        {
            _commissionService = commissionService;
        }

        [ProducesResponseType(typeof(CommissionCalculationResponse), 200)]
        [HttpPost]
        public IActionResult Calculate(CommissionCalculationRequest request)
        {
            var validationResult = CommissionValidator.Validate(request);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.ErrorMessage);

            var result = _commissionService.Calculate(request);
            return Ok(result);
        }
    }
}