using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployer;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofWarehouse;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofWarehouse
{
    public class EmployerMWCommodityValidator : MWCommodityValidator<EmployerMWCommodity>
    {
        public EmployerMWCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerMWCommodity>.CreateWithOptions((EmployerMWCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}