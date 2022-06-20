using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon.ofEmployer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofUser.ofEmployer
{
    public class EmployerEntityValidator<TEntity> : EntityDTOValidator<TEntity>, IValidator<TEntity> where TEntity : EntityDTO
    {
        public EmployerEntityValidator()
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
    public class EmployerCenterValidator<TCenter> : CenterDTOValidator<TCenter>, IValidator<TCenter> where TCenter : EmployerCenter
    {
        public EmployerCenterValidator()
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
    public class EmployerCommodityValidator<TCommodity> : CommodityDTOValidator<TCommodity>, IValidator<TCommodity> where TCommodity : EmployerCommodity
    {
        public EmployerCommodityValidator()
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
    public class EmployerStatusValidator<TStatus> : StatusDTOValidator<TStatus>, IValidator<TStatus> where TStatus : EmployerStatus, new()
    {
        public EmployerStatusValidator()
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
    public class EmployerSStatusValidator<TSStatus> : SStatusDTOValidator<TSStatus>, IValidator<TSStatus> where TSStatus : EmployerSStatus, new()
    {
        public EmployerSStatusValidator()
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
    public class EmployerMStatusValidator<TMStatus> : MStatusDTOValidator<TMStatus>, IValidator<TMStatus> where TMStatus : EmployerMStatus, new()
    {
        public EmployerMStatusValidator()
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
    public class EmployerEStatusValidator<TEStatus> : EStatusDTOValidator<TEStatus>, IValidator<TEStatus> where TEStatus : EmployerEStatus, new()
    {
        public EmployerEStatusValidator()
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