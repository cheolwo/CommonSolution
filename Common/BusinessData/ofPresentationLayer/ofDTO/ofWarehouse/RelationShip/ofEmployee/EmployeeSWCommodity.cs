using AutoMapper;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee
{
    [AutoMap(typeof(SWCommodity))]
    [HttpDTOService(typeof(EmployeeSWCommodityService))]
    public class EmployeeSWCommodity : SWCommodityDTO
    {
       
    }
}
