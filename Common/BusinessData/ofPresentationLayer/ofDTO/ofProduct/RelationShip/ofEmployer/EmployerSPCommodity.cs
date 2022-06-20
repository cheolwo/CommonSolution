using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer
{
    [AutoMap(typeof(SPCommodity))]
    [HttpDTOService(typeof(EmployerSPCommodityService))]
    [ActorContext(typeof(EmployerProducterContext))]
    public class EmployerSPCommodity : SPCommodityDTO
    {
       
    }   
}
