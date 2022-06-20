using AutoMapper;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployee
{
    [AutoMap(typeof(MOCommodity))]
    [HttpDTOService(typeof(EmployeeMOCommodityService))]
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeMOCommodity : MOCommodityDTO
    {
       
    }
}
