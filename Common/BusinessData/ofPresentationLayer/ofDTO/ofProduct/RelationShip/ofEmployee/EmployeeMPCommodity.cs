using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;

namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee
{
    [AutoMap(typeof(MPCommodity))]
    [HttpDTOService(typeof(EmployeeMPCommodityService))]
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeeMPCommodity : MPCommodityDTO
    {   
       
    }
}
