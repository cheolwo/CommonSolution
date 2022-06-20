using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;

namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee
{
    [AutoMap(typeof(EPCommodity))]
    [HttpDTOService(typeof(EmployeeEPCommodityService))]
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeeEPCommodity : EPCommodityDTO
    {   
       
    }
}
