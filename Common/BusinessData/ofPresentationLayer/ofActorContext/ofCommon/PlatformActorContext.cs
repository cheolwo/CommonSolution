using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofPlatform;
using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofPlatform;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofPlatform;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofPlatform;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofPlatform;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresendationLayer.ofDTOServices.ofTrade;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofActorService;
using BusinessData.ofPresendationLayer.ofCommon.ofBuilder;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofPlatform;
using BusinessData.ofPresentationLayer.ofStorage.ofPlatform;
using BusinessData.ofPresentationLayer.ofValidator.ofPlatform.ofHR;
using BusinessData.ofPresentationLayer.ofValidator.ofPlatform.ofJournal;
using BusinessData.ofPresentationLayer.ofValidator.ofPlatform.ofWarehouse;
using BusinessData.ofPresentationLayer.ofValidator.ofPlatform.ofTrade;
using BusinessData.ofPresentationLayer.ofValidator.ofPlatform.ofGroupOrder;
using BusinessData.ofPresentationLayer.ofValidator.ofPlatform.ofOrder;
using BusinessData.ofPresentationLayer.ofValidator.ofPlatform.ofMarket;

namespace BusinessData.ofPresendationLayer.ofActorContext.ofCommon
{
    public class PlatformActorContext : UserActorContext
    {
        public PlatformActorContext(ActorServiceOption options)
            :base(options)
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(PlatformEmployeeRole), new PlatformEmployeeRoleService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(PlatformHRBusinessPart), new PlatformHRBusinessPartService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(PlatformHRCenter), new PlatformHRCenterService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(PlatformHREmployee), new PlatformHREmployeeService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(PlatformHRRole), new PlatformHRRoleService(_options.HRServiceOptions));

            serviceBuilder.Add(nameof(PlatformJCommodity), new PlatformJCommodityService(_options.JournalServiceOptions));
            serviceBuilder.Add(nameof(PlatformJournal), new PlatformJournalService(_options.JournalServiceOptions));
            serviceBuilder.Add(nameof(PlatformJournalCenter), new PlatformJournalCenterService(_options.JournalServiceOptions));

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

            serviceBuilder.Add(nameof(PlatformGOC), new PlatformGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformGOCC), new PlatformGOCCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformSGOC), new PlatformSGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformMGOC), new PlatformMGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformEGOC), new PlatformEGOCService(_options.GroupOrderServiceOptions));

            serviceBuilder.Add(nameof(PlatformOrderCenter), new PlatformOrderCenterService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformOCommodity), new PlatformOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformSOCommodity), new PlatformSOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformMOCommodity), new PlatformMOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(PlatformEOCommodity), new PlatformEOCommodityService(_options.OrderServiceOptions));

            serviceBuilder.Add(nameof(PlatformEMCommodity), new PlatformEMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformSMCommodity), new PlatformSMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformMMCommodity), new PlatformMMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformMCommodity), new PlatformMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformPlatMarket), new PlatformPlatMarketService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(PlatformMarket), new PlatformMarketService(_options.MarketServiceOptions));

            serviceBuilder.Add(nameof(PlatformProducter), new PlatformProducterService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformEPCommodity), new PlatformEPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformSPCommodity), new PlatformSPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformMPCommodity), new PlatformMPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformProductCenter), new PlatformProductCenterService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformProductLand), new PlatformProductLandService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(PlatformPCommodity), new PlatformPCommodityService(_options.ProductServiceOptions));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {
            PlatformGroupOrderNMemoryDatabase PlatformGroupOrderNMemoryDatabase = new();
            PlatformHRNMemoryDatabase PlatformHRNMemoryDatabase = new();
            PlatformJournalNMemoryDatabase PlatformJournalNMemoryDatabase = new();
            PlatformMarketNMemoryDatabase PlatformMarketNMemoryDatabase = new();
            PlatformOrderNMemoryDatabase PlatformOrderNMemoryDatabase = new();
            PlatformProductNMemoryDatabase PlatformProductNMemoryDatabase = new();
            PlatformTradeNMemoryDatabase PlatformTradeNMemoryDatabase = new();
            PlatformWarehouseNMemoryDatabase PlatformWarehouseNMemoryDatabase = new();

            StorageBuilder.Add(nameof(PlatformEmployeeRole), PlatformHRNMemoryDatabase.PlatformEmployeeRoles);
            StorageBuilder.Add(nameof(PlatformHRBusinessPart), PlatformHRNMemoryDatabase.PlatformHRBusinessParts);
            StorageBuilder.Add(nameof(PlatformHRCenter), PlatformHRNMemoryDatabase.PlatformHRCenters);
            StorageBuilder.Add(nameof(PlatformHREmployee), PlatformHRNMemoryDatabase.PlatformHREmployees);
            StorageBuilder.Add(nameof(PlatformHRRole), PlatformHRNMemoryDatabase.PlatformHRRoles);

            StorageBuilder.Add(nameof(PlatformJCommodity), PlatformJournalNMemoryDatabase.PlatformJCommoditys);
            StorageBuilder.Add(nameof(PlatformJournal), PlatformJournalNMemoryDatabase.PlatformJournals);
            StorageBuilder.Add(nameof(PlatformJournalCenter), PlatformJournalNMemoryDatabase.PlatformJournalCenters);

            StorageBuilder.Add(nameof(PlatformWarehouse), PlatformWarehouseNMemoryDatabase.PlatformWarehouses);
            StorageBuilder.Add(nameof(PlatformWCommodity), PlatformWarehouseNMemoryDatabase.PlatformWCommoditys);
            StorageBuilder.Add(nameof(PlatformSWCommodity), PlatformWarehouseNMemoryDatabase.PlatformSWCommoditys);
            StorageBuilder.Add(nameof(PlatformMWCommodity), PlatformWarehouseNMemoryDatabase.PlatformMWCommoditys);
            StorageBuilder.Add(nameof(PlatformEWCommodity), PlatformWarehouseNMemoryDatabase.PlatformEWCommoditys);
            StorageBuilder.Add(nameof(PlatformDividedTag), PlatformWarehouseNMemoryDatabase.PlatformDividedTags);
            StorageBuilder.Add(nameof(PlatformDotBarcode), PlatformWarehouseNMemoryDatabase.PlatformDotBarcodes);
            StorageBuilder.Add(nameof(PlatformIncomingTag), PlatformWarehouseNMemoryDatabase.PlatformIncomingTags);
            StorageBuilder.Add(nameof(PlatformLoadFrame), PlatformWarehouseNMemoryDatabase.PlatformLoadFrames);
            StorageBuilder.Add(nameof(PlatformWorkingDesk), PlatformWarehouseNMemoryDatabase.PlatformWorkingDesks);

            StorageBuilder.Add(nameof(PlatformTradeCenter), PlatformTradeNMemoryDatabase.PlatformTradeCenters);
            StorageBuilder.Add(nameof(PlatformTCommodity), PlatformTradeNMemoryDatabase.PlatformTCommoditys);
            StorageBuilder.Add(nameof(PlatformSTCommodity), PlatformTradeNMemoryDatabase.PlatformSTCommoditys);
            StorageBuilder.Add(nameof(PlatformMTCommodity), PlatformTradeNMemoryDatabase.PlatformMTCommoditys);
            StorageBuilder.Add(nameof(PlatformETCommodity), PlatformTradeNMemoryDatabase.PlatformETCommoditys);

            StorageBuilder.Add(nameof(PlatformGOC), PlatformGroupOrderNMemoryDatabase.PlatformGOCS);
            StorageBuilder.Add(nameof(PlatformGOCC), PlatformGroupOrderNMemoryDatabase.PlatformGOCCS);
            StorageBuilder.Add(nameof(PlatformSGOC), PlatformGroupOrderNMemoryDatabase.PlatformSGOCS);
            StorageBuilder.Add(nameof(PlatformMGOC), PlatformGroupOrderNMemoryDatabase.PlatformMGOCS);
            StorageBuilder.Add(nameof(PlatformEGOC), PlatformGroupOrderNMemoryDatabase.PlatformEGOCS);

            StorageBuilder.Add(nameof(PlatformOrderCenter), PlatformOrderNMemoryDatabase.PlatformOrderCenters);
            StorageBuilder.Add(nameof(PlatformOCommodity), PlatformOrderNMemoryDatabase.PlatformOCommoditys);
            StorageBuilder.Add(nameof(PlatformSOCommodity), PlatformOrderNMemoryDatabase.PlatformSOCommoditys);
            StorageBuilder.Add(nameof(PlatformMOCommodity), PlatformOrderNMemoryDatabase.PlatformMOCommoditys);
            StorageBuilder.Add(nameof(PlatformEOCommodity), PlatformOrderNMemoryDatabase.PlatformEOCommoditys);

            StorageBuilder.Add(nameof(PlatformEMCommodity), PlatformMarketNMemoryDatabase.PlatformEMCommoditys);
            StorageBuilder.Add(nameof(PlatformSMCommodity), PlatformMarketNMemoryDatabase.PlatformSMCommoditys);
            StorageBuilder.Add(nameof(PlatformMMCommodity), PlatformMarketNMemoryDatabase.PlatformMMCommoditys);
            StorageBuilder.Add(nameof(PlatformMCommodity), PlatformMarketNMemoryDatabase.PlatformMCommoditys);
            StorageBuilder.Add(nameof(PlatformPlatMarket), PlatformMarketNMemoryDatabase.PlatformPlatMarkets);
            StorageBuilder.Add(nameof(PlatformMarket), PlatformMarketNMemoryDatabase.PlatformMarkets);

            StorageBuilder.Add(nameof(PlatformProducter), PlatformProductNMemoryDatabase.PlatformProducters);
            StorageBuilder.Add(nameof(PlatformEPCommodity), PlatformProductNMemoryDatabase.PlatformEPCommoditys);
            StorageBuilder.Add(nameof(PlatformSPCommodity), PlatformProductNMemoryDatabase.PlatformSPCommoditys);
            StorageBuilder.Add(nameof(PlatformMPCommodity), PlatformProductNMemoryDatabase.PlatformMPCommoditys);
            StorageBuilder.Add(nameof(PlatformProductCenter), PlatformProductNMemoryDatabase.PlatformProductCenters);
            StorageBuilder.Add(nameof(PlatformProductLand), PlatformProductNMemoryDatabase.PlatformProductLands);
            StorageBuilder.Add(nameof(PlatformPCommodity), PlatformProductNMemoryDatabase.PlatformPCommoditys);
        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {
            ValidatorBuilder.Add(nameof(PlatformEmployeeRole), new PlatformEmployeeRoleValidator());
            ValidatorBuilder.Add(nameof(PlatformHRBusinessPart), new PlatformHRBusinessPartValidator());
            ValidatorBuilder.Add(nameof(PlatformHRCenter), new PlatformHRCenterValidator());
            ValidatorBuilder.Add(nameof(PlatformHREmployee), new PlatformHREmployeeValidator());
            ValidatorBuilder.Add(nameof(PlatformHRRole), new PlatformHRRoleValidator());

            ValidatorBuilder.Add(nameof(PlatformJCommodity), new PlatformJCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformJournal), new PlatformJournalValidator());
            ValidatorBuilder.Add(nameof(PlatformJournalCenter), new PlatformJournalCenterValidator());

            ValidatorBuilder.Add(nameof(PlatformWarehouse), new PlatformWarehouseValidator());
            ValidatorBuilder.Add(nameof(PlatformWCommodity), new PlatformWCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformSWCommodity), new PlatformSWCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformMWCommodity), new PlatformMWCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformEWCommodity), new PlatformEWCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformDividedTag), new PlatformDividedTagValidator());
            ValidatorBuilder.Add(nameof(PlatformDotBarcode), new PlatformDotBarcodeValidator());
            ValidatorBuilder.Add(nameof(PlatformIncomingTag), new PlatformIncomingTagValidator());
            ValidatorBuilder.Add(nameof(PlatformLoadFrame), new PlatformLoadFrameValidator());
            ValidatorBuilder.Add(nameof(PlatformWorkingDesk), new PlatformWorkingDeskValidator());

            ValidatorBuilder.Add(nameof(PlatformTradeCenter), new PlatformTradeCenterValidator());
            ValidatorBuilder.Add(nameof(PlatformTCommodity), new PlatformTCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformSTCommodity), new PlatformSTCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformMTCommodity), new PlatformMTCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformETCommodity), new PlatformETCommodityValidator());

            ValidatorBuilder.Add(nameof(PlatformGOC), new PlatformGOCValidator());
            ValidatorBuilder.Add(nameof(PlatformGOCC), new PlatformGOCCValidator());
            ValidatorBuilder.Add(nameof(PlatformSGOC), new PlatformSGOCValidator());
            ValidatorBuilder.Add(nameof(PlatformMGOC), new PlatformMGOCValidator());
            ValidatorBuilder.Add(nameof(PlatformEGOC), new PlatformEGOCValidator());

            ValidatorBuilder.Add(nameof(PlatformOrderCenter), new PlatformOrderCenterValidator());
            ValidatorBuilder.Add(nameof(PlatformOCommodity), new PlatformOCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformSOCommodity), new PlatformSOCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformMOCommodity), new PlatformMOCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformEOCommodity), new PlatformEOCommodityValidator());

            ValidatorBuilder.Add(nameof(PlatformEMCommodity), new PlatformEMCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformSMCommodity), new PlatformSMCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformMMCommodity), new PlatformMMCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformMCommodity), new PlatformMCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformPlatMarket), new PlatformPlatMarketValidator());
            ValidatorBuilder.Add(nameof(PlatformMarket), new PlatformMarketValidator());

            ValidatorBuilder.Add(nameof(PlatformProducter), new PlatformProducterValidator());
            ValidatorBuilder.Add(nameof(PlatformEPCommodity), new PlatformEPCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformSPCommodity), new PlatformSPCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformMPCommodity), new PlatformMPCommodityValidator());
            ValidatorBuilder.Add(nameof(PlatformProductCenter), new PlatformProductCenterValidator());
            ValidatorBuilder.Add(nameof(PlatformProductLand), new PlatformProductLandValidator());
            ValidatorBuilder.Add(nameof(PlatformPCommodity), new PlatformPCommodityValidator());
        }
    }
}
