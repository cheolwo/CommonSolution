using AutoMapper;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;
namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofPlatform
{
    [AutoMap(typeof(OCommodity))]
    [HttpDTOService(typeof(PlatformOCommodityService))]
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOCommodity : OCommodityDTO
    {
        
    }
}
