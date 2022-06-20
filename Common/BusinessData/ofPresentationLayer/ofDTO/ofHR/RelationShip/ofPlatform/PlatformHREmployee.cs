using AutoMapper;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofPlatform
{
    [AutoMap(typeof(HREmployee))]
    [HttpDTOService(typeof(PlatformHREmployeeService))]
    [ActorContext(typeof(PlatformActorContext))]
    public class PlatformHREmployee : HREmployeeDTO
    {
        
    }
}