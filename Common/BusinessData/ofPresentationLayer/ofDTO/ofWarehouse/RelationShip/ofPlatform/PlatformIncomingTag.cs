using AutoMapper;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform
{
    [AutoMap(typeof(IncomingTag))]
    [HttpDTOService(typeof(PlatformIncomingTagService))]
    public class PlatformIncomingTag : IncomingTagDTO
    {
        
    }
}
