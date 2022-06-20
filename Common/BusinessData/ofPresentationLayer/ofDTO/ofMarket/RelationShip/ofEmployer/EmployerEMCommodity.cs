using AutoMapper;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployer
{
    [AutoMap(typeof(EMCommodity))]
    [HttpDTOService(typeof(EmployerEMCommodityService))]
    [ActorContext(typeof(EmployerSellerContext))]
    public class EmployerEMCommodity : EMCommodityDTO
    {
        
    }
}
