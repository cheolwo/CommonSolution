using AutoMapper;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployer
{
    [AutoMap(typeof(SMCommodity))]
    [HttpDTOService(typeof(EmployerSMCommodityService))]
    [ActorContext(typeof(EmployerSellerContext))]
    public class EmployerSMCommodity : SMCommodityDTO
    {
       
    }
}
