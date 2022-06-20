using AutoMapper;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee
{
    [AutoMap(typeof(LoadFrame))]
    [HttpDTOService(typeof(EmployeeLoadFrameService))]
    public class EmployeeLoadFrame : LoadFrameDTO
    {
    }
}
