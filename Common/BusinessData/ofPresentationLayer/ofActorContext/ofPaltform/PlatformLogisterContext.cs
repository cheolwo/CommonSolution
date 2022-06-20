using BusinessData.ofActorService;
using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofCommon.ofBuilder;
using BusinessData.ofPresendationLayer.ofDTOServices.ofTrade;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofPlatform;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessData.ofPresendationLayer.ofActorContext.ofPlatform
{
    public class PlatformLogisterContext : PlatformActorContext
    {
        public PlatformLogisterContext(ActorServiceOption options)
            : base(options)
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

            serviceBuilder.Add(nameof(PlatformTradeCenter), new PlatformTradeCenterService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(PlatformTCommodity), new PlatformTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(PlatformSTCommodity), new PlatformSTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(PlatformMTCommodity), new PlatformMTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(PlatformETCommodity), new PlatformETCommodityService(_options.TradeServiceOptions));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
