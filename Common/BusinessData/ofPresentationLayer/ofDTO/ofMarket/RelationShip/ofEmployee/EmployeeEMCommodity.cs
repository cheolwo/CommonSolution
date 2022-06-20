using AutoMapper;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee
{
    [AutoMap(typeof(EMCommodity))]
    [HttpDTOService(typeof(EmployeeEMCommodityService))]
    [ActorContext(typeof(EmployeeSellerContext))]
    public class EmployeeEMCommodity : EMCommodityDTO
    {
        
    }
}
