using AutoMapper;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee
{
    [AutoMap(typeof(MMCommodity))]
    [HttpDTOService(typeof(EmployeeMMCommodityService))]
    [ActorContext(typeof(EmployeeSellerContext))]
    public class EmployeeMMCommodity : MMCommodityDTO
    {
       
    }
}
