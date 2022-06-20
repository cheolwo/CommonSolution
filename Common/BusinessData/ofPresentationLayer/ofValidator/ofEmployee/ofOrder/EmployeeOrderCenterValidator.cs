using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployee;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofOrder;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofEmployee.ofOrder
{
    public class EmployeeOrderCenterValidator : OrderCenterValidator<EmployeeOrderCenter>
    {
        public EmployeeOrderCenterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeOrderCenter>.CreateWithOptions((EmployeeOrderCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}