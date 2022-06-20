using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlatform;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofGroupOrder;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofPlatform.ofGroupOrder
{
    public class PlatformGOCValidator : GOCValidator<PlatformGOC>
    {
        public PlatformGOCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformGOC>.CreateWithOptions((PlatformGOC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}