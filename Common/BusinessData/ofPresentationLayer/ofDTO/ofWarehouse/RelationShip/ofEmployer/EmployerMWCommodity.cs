using AutoMapper;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployer
{
    [AutoMap(typeof(MWCommodity))]
    [HttpDTOService(typeof(EmployerMWCommodityService))]
    public class EmployerMWCommodity : MWCommodityDTO
    {
        
    }
}
