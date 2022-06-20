using AutoMapper;
using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofTrade;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofPlatform
{
    [AutoMap(typeof(TradeCenter))]
    [HttpDTOService(typeof(PlatformTradeCenterService))]
    public class PlatformTradeCenter : TradeCenterDTO
    {
       
    }
}
