using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofPlatform;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofHR;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofPlatform.ofHR
{
    public class PlatformHRRoleValidator : HRRoleValidator<PlatformHRRole>
    {
        public PlatformHRRoleValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformHRRole>.CreateWithOptions((PlatformHRRole)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}