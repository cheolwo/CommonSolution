using AutoMapper;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofPlatform
{
    [AutoMap(typeof(JCommodity))]
    [HttpDTOService(typeof(PlatformJCommodityService))]
    [ActorContext(typeof(PlatformActorContext))]
    public class PlatformJCommodity : JCommodityDTO
    {
       
    }
}
