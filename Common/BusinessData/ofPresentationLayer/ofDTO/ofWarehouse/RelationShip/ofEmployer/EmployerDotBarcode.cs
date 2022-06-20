using AutoMapper;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
namespace BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployer
{
    [AutoMap(typeof(DotBarcode))]
    [HttpDTOService(typeof(EmployerDotBarcodeService))]
    public class EmployerDotBarcode : DotBarcodeDTO
    {

    }
}
