using AutoMapper;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployer
{
    [AutoMap(typeof(HRBusinessPart))]
    [HttpDTOService(typeof(EmployerHRBusinessPartService))]
    [ActorContext(typeof(EmployerActorContext))]
    public class EmployerHRBusinessPart : HRBusinessPartDTO
    {
        
    }
}