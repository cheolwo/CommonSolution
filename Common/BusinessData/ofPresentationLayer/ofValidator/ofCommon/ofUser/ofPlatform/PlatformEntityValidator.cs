using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon.ofPlatform;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofUser.ofPlatform
{
    public class PlatformEntityValidator<TEntity> : EntityDTOValidator<TEntity>, IValidator<TEntity> where TEntity : EntityDTO
    {
        public PlatformEntityValidator()
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
    public class PlatformCenterValidator<TCenter> : CenterDTOValidator<TCenter>, IValidator<TCenter> where TCenter : PlatformCenter
    {
        public PlatformCenterValidator()
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
    public class PlatformCommodityValidator<TCommodity> : CommodityDTOValidator<TCommodity>, IValidator<TCommodity> where TCommodity : PlatformCommodity
    {
        public PlatformCommodityValidator()
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
    public class PlatformStatusValidator<TStatus> : StatusDTOValidator<TStatus>, IValidator<TStatus> where TStatus : PlatformStatus, new()
    {
        public PlatformStatusValidator()
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
    public class PlatformSStatusValidator<TSStatus> : SStatusDTOValidator<TSStatus>, IValidator<TSStatus> where TSStatus : PlatformSStatus, new()
    {
        public PlatformSStatusValidator()
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
    public class PlatformMStatusValidator<TMStatus> : MStatusDTOValidator<TMStatus>, IValidator<TMStatus> where TMStatus : PlatformMStatus, new()
    {
        public PlatformMStatusValidator()
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
    public class PlatformEStatusValidator<TEStatus> : EStatusDTOValidator<TEStatus>, IValidator<TEStatus> where TEStatus : PlatformEStatus, new()
    {
        public PlatformEStatusValidator()
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