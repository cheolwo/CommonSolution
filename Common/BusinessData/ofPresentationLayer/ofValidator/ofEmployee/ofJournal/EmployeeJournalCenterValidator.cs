using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployee;
using BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofJournal;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofEmployee.ofJournal
{
    public class EmployeeJournalCenterValidator : JournalCenterValidator<EmployeeJournalCenter>
    {
        public EmployeeJournalCenterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeJournalCenter>.CreateWithOptions((EmployeeJournalCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}