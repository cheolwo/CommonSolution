using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofPlatform
{
    [AutoMap(typeof(SPCommodity))]
    [HttpDTOService(typeof(PlatformSPCommodityService))]
    [ActorContext(typeof(PlatformProducterContext))]
    public class PlatformSPCommodity : SPCommodityDTO
    {
       
    }   
}
