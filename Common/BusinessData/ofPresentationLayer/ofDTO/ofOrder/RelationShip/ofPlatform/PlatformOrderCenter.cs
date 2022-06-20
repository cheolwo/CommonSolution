using AutoMapper;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofPlatform;
namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofPlatform
{
    [AutoMap(typeof(OrderCenter))]
    [HttpDTOService(typeof(PlatformOrderCenterService))]
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformOrderCenter : OrderCenterDTO
    {
       
    }
}
