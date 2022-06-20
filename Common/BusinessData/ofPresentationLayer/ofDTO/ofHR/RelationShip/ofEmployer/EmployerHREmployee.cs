using AutoMapper;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployer
{
    [AutoMap(typeof(HREmployee))]
    [HttpDTOService(typeof(EmployerHREmployeeService))]
    [ActorContext(typeof(EmployerActorContext))]
    public class EmployerHREmployee : HREmployeeDTO
    {
       
    }
}