using AutoMapper;
using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofTrade;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployee
{
    [AutoMap(typeof(MTCommodity))]
    [HttpDTOService(typeof(EmployeeMTCommodityService))]
    public class EmployeeMTCommodity : MTCommodityDTO
    {
        
    }
}
