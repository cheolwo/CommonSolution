using AutoMapper;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployee
{
    [AutoMap(typeof(Journal))]
    [HttpDTOService(typeof(EmployeeJournalService))]
    [ActorContext(typeof(EmployeeActorContext))]
    public class EmployeeJournal : JournalDTO
    {
        
    }
}
