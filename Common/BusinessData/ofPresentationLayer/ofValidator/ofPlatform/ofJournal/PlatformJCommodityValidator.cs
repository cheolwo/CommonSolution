using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofPlatform;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofJournal;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofValidator.ofPlatform.ofJournal
{
    public class PlatformJCommodityValidator : JCommodityValidator<PlatformJCommodity>
    {
        public PlatformJCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformJCommodity>.CreateWithOptions((PlatformJCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}