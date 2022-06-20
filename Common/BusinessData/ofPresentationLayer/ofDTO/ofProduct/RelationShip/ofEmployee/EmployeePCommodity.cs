using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee
{
    [AutoMap(typeof(PCommodity))]
    [HttpDTOService(typeof(EmployeePCommodityService))]
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeePCommodity : PCommodityDTO
    {
       
    }
}
