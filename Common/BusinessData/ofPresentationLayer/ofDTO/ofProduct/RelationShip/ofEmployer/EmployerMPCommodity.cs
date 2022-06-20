using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer
{
    [AutoMap(typeof(MPCommodity))]
    [HttpDTOService(typeof(EmployerMPCommodityService))]
    [ActorContext(typeof(EmployerProducterContext))]
    public class EmployerMPCommodity : MPCommodityDTO
    {   
  
    }
}
