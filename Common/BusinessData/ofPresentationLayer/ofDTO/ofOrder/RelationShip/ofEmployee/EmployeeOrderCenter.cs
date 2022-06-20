using AutoMapper;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployee
{
    [AutoMap(typeof(OrderCenter))]
    [HttpDTOService(typeof(EmployeeOrderCenterService))]
    [ActorContext(typeof(EmployeeOrdererContext))]
    public class EmployeeOrderCenter : OrderCenterDTO
    {
       
    }
}
