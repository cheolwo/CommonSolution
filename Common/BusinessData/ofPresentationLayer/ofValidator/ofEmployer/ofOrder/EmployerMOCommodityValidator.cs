using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployer;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofOrder;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofOrder
{
    public class EmployerMOCommodityValidator : MOCommodityValidator<EmployerMOCommodity>
    {
        public EmployerMOCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerMOCommodity>.CreateWithOptions((EmployerMOCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}