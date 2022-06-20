using AutoMapper;
using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofTrade;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployer
{
    [AutoMap(typeof(TradeCenter))]
    [HttpDTOService(typeof(EmployerTradeCenterService))]
    public class EmployerTradeCenter : TradeCenterDTO
    {
        
    }
}
