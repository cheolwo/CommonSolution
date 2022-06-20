using AutoMapper;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofPlatform
{
    [AutoMap(typeof(HRCenter))]
    [HttpDTOService(typeof(PlatformHRCenterService))]
    [ActorContext(typeof(PlatformActorContext))]
    public class PlatformHRCenter : HRCenterDTO
    {
        
    }
}