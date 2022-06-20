using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployer;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofHR;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofHR
{
    public class EmployerHRBusinessPartValidator : HRBusinessPartValidator<EmployerHRBusinessPart>
    {
        public EmployerHRBusinessPartValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerHRBusinessPart>.CreateWithOptions((EmployerHRBusinessPart)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}