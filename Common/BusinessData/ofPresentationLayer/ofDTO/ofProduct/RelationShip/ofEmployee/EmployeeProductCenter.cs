using AutoMapper;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessView.ofUser.ofCommon;
using BusinessView.ofUser.ofEmployee;
namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee
{
    public static class LandCode 
    {
        public const string Product = "Product";
        public const string LiveStock = "LiveStock";
    }
    [AutoMap(typeof(ProductCenter))]
    [HttpDTOService(typeof(EmployeeProductCenterService))]
    [ActorContext(typeof(EmployeeProducterContext))]
    public class EmployeeProductCenter : ProductCenterDTO
    {
       
    }
}
