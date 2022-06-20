using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon.ofEmployee;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofUser.ofEmployee
{
    public class EmployeeEntityValidator<TEntity> : EntityDTOValidator<TEntity>, IValidator<TEntity> where TEntity : EntityDTO
    {
        public EmployeeEntityValidator()
        {
            
        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TEntity>.CreateWithOptions((TEntity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
    public class EmployeeCenterValidator<TCenter> : CenterDTOValidator<TCenter>, IValidator<TCenter> where TCenter : EmployeeCenter
    {
        public EmployeeCenterValidator()
        {
            RuleFor(x => x.LoginId)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.Password)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.Address)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.CountryCode)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .Length(1,100);
        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TCenter>.CreateWithOptions((TCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
    public class EmployeeCommodityValidator<TCommodity> : CommodityDTOValidator<TCommodity>, IValidator<TCommodity> where TCommodity : EmployeeCommodity
    {
        public EmployeeCommodityValidator()
        {
            RuleFor(x => x.HsCode)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.Barcode)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.CenterId)
                .NotEmpty()
                .Length(1,100);
        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TCommodity>.CreateWithOptions((TCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
    public class EmployeeStatusValidator<TStatus> : StatusDTOValidator<TStatus>, IValidator<TStatus> where TStatus : EmployeeStatus, new()
    {
        public EmployeeStatusValidator()
        {
            RuleFor(x => x.CommodityId)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.CenterId)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.Quantity)
                .NotEmpty();
        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TStatus>.CreateWithOptions((TStatus)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
    public class EmployeeSStatusValidator<TSStatus> : SStatusDTOValidator<TSStatus>, IValidator<TSStatus> where TSStatus : EmployeeSStatus, new()
    {
        public EmployeeSStatusValidator()
        {
            RuleFor(x => x.CommodityId)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.CenterId)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.Quantity)
                .NotEmpty();
        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TSStatus>.CreateWithOptions((TSStatus)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
    public class EmployeeMStatusValidator<TMStatus> : MStatusDTOValidator<TMStatus>, IValidator<TMStatus> where TMStatus : EmployeeMStatus, new()
    {
        public EmployeeMStatusValidator()
        {
            RuleFor(x => x.CommodityId)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.CenterId)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.Quantity)
                .NotEmpty();
        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TMStatus>.CreateWithOptions((TMStatus)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
    public class EmployeeEStatusValidator<TEStatus> : EStatusDTOValidator<TEStatus>, IValidator<TEStatus> where TEStatus : EmployeeEStatus, new()
    {
        public EmployeeEStatusValidator()
        {
            RuleFor(x => x.CommodityId)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.CenterId)
                .NotEmpty()
                .Length(1,100);
            RuleFor(x => x.Quantity)
                .NotEmpty();
        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TEStatus>.CreateWithOptions((TEStatus)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}