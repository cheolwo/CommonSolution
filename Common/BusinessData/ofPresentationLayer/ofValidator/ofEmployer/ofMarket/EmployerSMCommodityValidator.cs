using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployer;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofMarket;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofMarket
{
    public class EmployerSMCommodityValidator : SMCommodityValidator<EmployerSMCommodity>
    {
        public EmployerSMCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerSMCommodity>.CreateWithOptions((EmployerSMCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}