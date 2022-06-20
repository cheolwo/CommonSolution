using AutoMapper;
using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofTrade;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployee
{
    [AutoMap(typeof(ETCommodity))]
    [HttpDTOService(typeof(EmployeeETCommodityService))]
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeETCommodity : ETCommodityDTO
    {
        
    }
}
