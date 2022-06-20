using BusinessData.ofActorService;
using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofCommon.ofBuilder;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlatform;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofPlatform;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofPlatform;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofPlatform;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresendationLayer.ofDTOServices.ofTrade;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;

namespace BusinessData.ofPresendationLayer.ofActorContext.ofPlatform
{
    public class PlatformProducterContext : PlatformActorContext
    {
        public PlatformProducterContext(ActorServiceOption options)
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

            serviceBuilder.Add(nameof(PlatformGOC), new PlatformGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformGOCC), new PlatformGOCCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformSGOC), new PlatformSGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformMGOC), new PlatformMGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformEGOC), new PlatformEGOCService(_options.GroupOrderServiceOptions));

            serviceBuilder.Add(nameof(PlatformTradeCenter), new PlatformTradeCenterService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(PlatformTCommodity), new PlatformTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(PlatformSTCommodity), new PlatformSTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(PlatformMTCommodity), new PlatformMTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(PlatformETCommodity), new PlatformETCommodityService(_options.TradeServiceOptions));

            serviceBuilder.Add(nameof(PlatformOrderCenter), new PlatformOrderCenterService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformOCommodity), new PlatformOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformSOCommodity), new PlatformSOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformMOCommodity), new PlatformMOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformEOCommodity), new PlatformEOCommodityService(_options.OrderServiceOptions));

            serviceBuilder.Add(nameof(PlatformEMCommodity), new PlatformEMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformMarket), new PlatformMarketService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformMCommodity), new PlatformMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformSMCommodity), new PlatformSMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformMMCommodity), new PlatformMMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformPlatMarket), new PlatformPlatMarketService(_options.MarketServiceOptions));

            serviceBuilder.Add(nameof(PlatformProducterContext), new PlatformProducterService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformEPCommodity), new PlatformEPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformSPCommodity), new PlatformSPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformMPCommodity), new PlatformMPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformProductCenter), new PlatformProductCenterService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformProductLand), new PlatformProductLandService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformPCommodity), new PlatformPCommodityService(_options.ProductServiceOptions));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
