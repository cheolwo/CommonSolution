using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployer;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofTrade;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofTrade
{
    public class EmployerETCommodityValidator : ETCommodityValidator<EmployerETCommodity>
    {
        public EmployerETCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerETCommodity>.CreateWithOptions((EmployerETCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}