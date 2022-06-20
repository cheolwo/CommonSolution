using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofPlatform
{
    [AutoMap(typeof(PCommodity))]
    [HttpDTOService(typeof(PlatformPCommodityService))]
    [ActorContext(typeof(PlatformProducterContext))]
    public class PlatformPCommodity : PCommodityDTO
    {
      
    }
}
