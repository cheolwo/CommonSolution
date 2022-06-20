using AutoMapper;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform
{
    [AutoMap(typeof(MWCommodity))]
    [HttpDTOService(typeof(PlatformMWCommodityService))]
    public class PlatformMWCommodity : MWCommodityDTO
    {
        
    }
}
