using AutoMapper;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployee
{
    [AutoMap(typeof(JournalCenter))]
    [HttpDTOService(typeof(EmployeeJournalCenterService))]
    [ActorContext(typeof(EmployeeActorContext))]
    public class EmployeeJournalCenter : JournalCenterDTO
    {
        
    }
}
