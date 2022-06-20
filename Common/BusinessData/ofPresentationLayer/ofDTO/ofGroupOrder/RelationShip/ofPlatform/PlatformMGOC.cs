using AutoMapper;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;
using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofActorContext.ofPlatform;


namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlatform
{
    [AutoMap(typeof(MGOC))]
    [HttpDTOService(typeof(PlatformMGOCService))]
    [ActorContext(typeof(PlatformOrdererContext))]
    public class PlatformMGOC : MGOCDTO
    {

    }
}
