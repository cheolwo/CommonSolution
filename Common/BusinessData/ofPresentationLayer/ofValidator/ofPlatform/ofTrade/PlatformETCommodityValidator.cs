using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofPlatform;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofTrade;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofPlatform.ofTrade
{
    public class PlatformETCommodityValidator : ETCommodityValidator<PlatformETCommodity>
    {
        public PlatformETCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformETCommodity>.CreateWithOptions((PlatformETCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}