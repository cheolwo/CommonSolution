using AutoMapper;
using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofTrade;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofActorContext.ofEmployer;
namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployer
{
    [AutoMap(typeof(ETCommodity))]
    [HttpDTOService(typeof(EmployerETCommodityService))]
    public class EmployerETCommodity : ETCommodityDTO
    {
       
    }
}
