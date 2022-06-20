using AutoMapper;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployer
{
    [AutoMap(typeof(WCommodity))]
    [HttpDTOService(typeof(EmployerWCommodityService))]
    public class EmployerWCommodity : WCommodityDTO
    {
        
    }
}
