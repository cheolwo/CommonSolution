using AutoMapper;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform
{
    [AutoMap(typeof(EWCommodity))]
    [HttpDTOService(typeof(PlatformEWCommodityService))]
    public class PlatformEWCommodity : EWCommodityDTO
    {
       
    }
}
