using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;
using BusinessData.ofActorService;
using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofCommon.ofBuilder;

namespace BusinessData.ofPresendationLayer.ofActorContext.ofPlatform
{
    public class PlatformSellerContext : PlatformActorContext
    {
        public PlatformSellerContext(ActorServiceOption options)
            :base(options)
        {

        }


        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(PlatformWarehouse), new PlatformWarehouseService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformWCommodity), new PlatformWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformSWCommodity), new PlatformSWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformMWCommodity), new PlatformMWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformEWCommodity), new PlatformEWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformDividedTag), new PlatformDividedTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformDotBarcode), new PlatformDotBarcodeService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformIncomingTag), new PlatformIncomingTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformLoadFrame), new PlatformLoadFrameService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(PlatformWorkingDesk), new PlatformWorkingDeskService(_options.WarehouseServiceOptions));

            serviceBuilder.Add(nameof(PlatformEMCommodity), new PlatformEMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformSMCommodity), new PlatformSMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformMMCommodity), new PlatformMMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformMCommodity), new PlatformMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformPlatMarket), new PlatformPlatMarketService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformMarket), new PlatformMarketService(_options.MarketServiceOptions));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
