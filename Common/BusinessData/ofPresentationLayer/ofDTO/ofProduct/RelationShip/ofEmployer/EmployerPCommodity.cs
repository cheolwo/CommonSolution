using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer
{
    [AutoMap(typeof(PCommodity))]
    [HttpDTOService(typeof(EmployerPCommodityService))]
    [ActorContext(typeof(EmployerProducterContext))]
    public class EmployerPCommodity : PCommodityDTO
    {
        
    }
}
