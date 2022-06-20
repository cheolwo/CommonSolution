using BusinessData.ofActorService;
using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofCommon.ofBuilder;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee;

namespace BusinessData.ofPresendationLayer.ofActorContext.ofEmployee
{
    public class EmployeeSellerContext : EmployeeActorContext
    {
        public EmployeeSellerContext(ActorServiceOption options)
            :base(options)
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeWCommodity), new EmployeeWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSWCommodity), new EmployeeSWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMWCommodity), new EmployeeMWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeEWCommodity), new EmployeeEWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeDividedTag), new EmployeeDividedTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeDotBarcode), new EmployeeDotBarcodeService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeIncomingTag), new EmployeeIncomingTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeLoadFrame), new EmployeeLoadFrameService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployeeWorkingDesk), new EmployeeWorkingDeskService(_options.WarehouseServiceOptions));

            serviceBuilder.Add(nameof(EmployeeEMCommodity), new EmployeeEMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSMCommodity), new EmployeeSMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMMCommodity), new EmployeeMMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMCommodity), new EmployeeMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployeePlatMarket), new EmployeePlatMarketService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMarket), new EmployeeMarketService(_options.MarketServiceOptions));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
