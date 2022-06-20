using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofPlatform;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofOrder;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofPlatform.ofOrder
{
    public class PlatformOCommodityValidator : OCommodityValidator<PlatformOCommodity>
    {
        public PlatformOCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformOCommodity>.CreateWithOptions((PlatformOCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}