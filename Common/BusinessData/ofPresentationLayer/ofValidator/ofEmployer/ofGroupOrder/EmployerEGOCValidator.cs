using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployer;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofGroupOrder;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofGruopOrder
{
    public class EmployerEGOCValidator : EGOCValidator<EmployerEGOC>
    {
        public EmployerEGOCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerEGOC>.CreateWithOptions((EmployerEGOC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}