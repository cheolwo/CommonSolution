using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployer;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer
{
    [AutoMap(typeof(EPCommodity))]
    [HttpDTOService(typeof(EmployerEPCommodityService))]
    [ActorContext(typeof(EmployerProducterContext))]
    public class EmployerEPCommodity : EPCommodityDTO
    {   
       
    }
}
