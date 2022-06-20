using AutoMapper;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofCommon.ofUser;
using BusinessView.ofUser.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployer
{
    [AutoMap(typeof(JournalCenter))]
    [HttpDTOService(typeof(EmployerJournalCenterService))]
    [ActorContext(typeof(EmployerActorContext))]
    public class EmployerJournalCenter : JournalCenterDTO
    {
    }
}
