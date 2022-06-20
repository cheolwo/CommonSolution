using AutoMapper;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployee
{
    [AutoMap(typeof(HREmployee))]
    [HttpDTOService(typeof(EmployeeEmployeeRoleService))]
    [ActorContext(typeof(EmployeeActorContext))]
    public class EmployeeHREmployee : HREmployeeDTO
    {
        
    }
}