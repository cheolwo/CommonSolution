using AutoMapper;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;
using BusinessData.ofPresendationLayer.ofActorContext.ofPlatform;

namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlatform
{
    [AutoMap(typeof(SGOC))]
    [HttpDTOService(typeof(PlatformSGOCService))]
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformSGOC : SGOCDTO
    {

    }
}
