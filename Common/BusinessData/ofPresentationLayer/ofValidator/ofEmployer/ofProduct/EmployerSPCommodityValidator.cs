using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofProduct;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofProduct
{
    public class EmployerSPCommodityValidator : SPCommodityValidator<EmployerSPCommodity>
    {
        public EmployerSPCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerSPCommodity>.CreateWithOptions((EmployerSPCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}