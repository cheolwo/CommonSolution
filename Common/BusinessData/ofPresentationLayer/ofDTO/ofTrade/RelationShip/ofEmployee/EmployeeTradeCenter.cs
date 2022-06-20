using AutoMapper;
using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofTrade;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployee
{
    [AutoMap(typeof(TradeCenter))]
    [HttpDTOService(typeof(EmployeeTradeCenterService))]
    public class EmployeeTradeCenter : TradeCenterDTO
    {
        
    }
}
