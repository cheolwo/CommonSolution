using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofPlatform;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofProduct;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofPlatform.ofProduct
{
    public class PlatformProductCenterValidator : ProductCenterValidator<PlatformProductCenter>
    {
        public PlatformProductCenterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformProductCenter>.CreateWithOptions((PlatformProductCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}