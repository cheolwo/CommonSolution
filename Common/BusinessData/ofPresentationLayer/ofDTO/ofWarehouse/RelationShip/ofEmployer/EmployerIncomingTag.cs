using AutoMapper;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployer
{
    [AutoMap(typeof(IncomingTag))]
    [HttpDTOService(typeof(EmployerIncomingTagService))]
    public class EmployerIncomingTag : IncomingTagDTO
    {
        
    }
}
