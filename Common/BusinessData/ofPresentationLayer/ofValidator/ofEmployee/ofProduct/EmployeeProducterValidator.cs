using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofProduct;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofEmployee.ofProduct
{
    public class EmployeeProducterValidator : ProducterValidator<EmployeeProducter>
    {
        public EmployeeProducterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeProducter>.CreateWithOptions((EmployeeProducter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}