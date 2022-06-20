using AutoMapper;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployer
{
    [AutoMap(typeof(OrderCenter))]
    [HttpDTOService(typeof(EmployerOrderCenterService))]
    [ActorContext(typeof(EmployerOrdererContext))]
    public class EmployerOrderCenter : OrderCenterDTO
    {
       
    }
}
