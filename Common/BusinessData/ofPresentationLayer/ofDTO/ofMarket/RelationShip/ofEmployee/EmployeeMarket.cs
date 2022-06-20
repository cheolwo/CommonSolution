using AutoMapper;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee
{
    [AutoMap(typeof(Market))]
    [HttpDTOService(typeof(EmployeeMarketService))]
    [ActorContext(typeof(EmployeeSellerContext))]
    public class EmployeeMarket : MarketDTO
    {
       
    }
}
