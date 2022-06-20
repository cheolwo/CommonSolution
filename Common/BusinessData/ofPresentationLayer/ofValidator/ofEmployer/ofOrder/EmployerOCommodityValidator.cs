using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployer;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofOrder;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofOrder
{
    public class EmployerOCommodityValidator : OCommodityValidator<EmployerOCommodity>
    {
        public EmployerOCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerOCommodity>.CreateWithOptions((EmployerOCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}