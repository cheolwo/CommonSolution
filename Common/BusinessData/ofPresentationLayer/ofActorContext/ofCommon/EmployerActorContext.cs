using BusinessData.ofActorService;
using BusinessData.ofPresendationLayer.ofCommon.ofBuilder;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresendationLayer.ofDTOServices.ofTrade;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployer;
using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployer;
using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployer;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployer;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployer;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployer;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployer;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;
using BusinessData.ofPresentationLayer.ofStorage.ofEmployer;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofGruopOrder;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofHR;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofJournal;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofMarket;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofOrder;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofProduct;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofTrade;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployer.ofWarehouse;

namespace BusinessData.ofPresendationLayer.ofActorContext.ofCommon
{
    public class EmployerActorContext : UserActorContext
    {
        public EmployerActorContext(ActorServiceOption options)
            :base(options)
        {

        }


        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder)
        {
            serviceBuilder.Add(nameof(EmployerEmployeeRole), new EmployerEmployeeRoleService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(EmployerHRBusinessPart), new EmployerHRBusinessPartService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(EmployerHRCenter), new EmployerHRCenterService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(EmployerHREmployee), new EmployerHREmployeeService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(EmployerHRRole), new EmployerHRRoleService(_options.HRServiceOptions));

            serviceBuilder.Add(nameof(EmployerJCommodity), new EmployerJCommodityService(_options.JournalServiceOptions));
            serviceBuilder.Add(nameof(EmployerJournal), new EmployerJournalService(_options.JournalServiceOptions));
            serviceBuilder.Add(nameof(EmployerJournalCenter), new EmployerJournalCenterService(_options.JournalServiceOptions));

            serviceBuilder.Add(nameof(EmployerWarehouse), new EmployerWarehouseService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerWCommodity), new EmployerWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerSWCommodity), new EmployerSWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerMWCommodity), new EmployerMWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerEWCommodity), new EmployerEWCommodityService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerDividedTag), new EmployerDividedTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerDotBarcode), new EmployerDotBarcodeService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerIncomingTag), new EmployerIncomingTagService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerLoadFrame), new EmployerLoadFrameService(_options.WarehouseServiceOptions));
            serviceBuilder.Add(nameof(EmployerWorkingDesk), new EmployerWorkingDeskService(_options.WarehouseServiceOptions));

            serviceBuilder.Add(nameof(EmployerTradeCenter), new EmployerTradeCenterService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployerTCommodity), new EmployerTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployerSTCommodity), new EmployerSTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployerMTCommodity), new EmployerMTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployerETCommodity), new EmployerETCommodityService(_options.TradeServiceOptions));

            serviceBuilder.Add(nameof(EmployerGOC), new EmployerGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerGOCC), new EmployerGOCCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerSGOC), new EmployerSGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerMGOC), new EmployerMGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerEGOC), new EmployerEGOCService(_options.GroupOrderServiceOptions));

            serviceBuilder.Add(nameof(EmployerOrderCenter), new EmployerOrderCenterService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerOCommodity), new EmployerOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerSOCommodity), new EmployerSOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerMOCommodity), new EmployerMOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployerEOCommodity), new EmployerEOCommodityService(_options.OrderServiceOptions));

            serviceBuilder.Add(nameof(EmployerEMCommodity), new EmployerEMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployerSMCommodity), new EmployerSMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployerMMCommodity), new EmployerMMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployerMCommodity), new EmployerMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployerPlatMarket), new EmployerPlatMarketService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployerMarket), new EmployerMarketService(_options.MarketServiceOptions));

            serviceBuilder.Add(nameof(EmployerProducter), new EmployerProducterService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployerEPCommodity), new EmployerEPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployerSPCommodity), new EmployerSPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployerMPCommodity), new EmployerMPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployerProductCenter), new EmployerProductCenterService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployerProductLand), new EmployerProductLandService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployerPCommodity), new EmployerPCommodityService(_options.ProductServiceOptions));
        }
        protected override void OnStrorageBuilder(StorageBuilder StorageBuilder)
        {
            EmployerGroupOrderNMemoryDatabase EmployerGroupOrderNMemoryDatabase = new();
            EmployerHRNMemoryDatabase EmployerHRNMemoryDatabase = new();
            EmployerJournalNMemoryDatabase EmployerJournalNMemoryDatabase = new();
            EmployerMarketNMemoryDatabase EmployerMarketNMemoryDatabase = new();
            EmployerOrderNMemoryDatabase EmployerOrderNMemoryDatabase = new();
            EmployerProductNMemoryDatabase EmployerProductNMemoryDatabase = new();
            EmployerTradeNMemoryDatabase EmployerTradeNMemoryDatabase = new();
            EmployerWarehouseNMemoryDatabase EmployerWarehouseNMemoryDatabase = new();

            StorageBuilder.Add(nameof(EmployerEmployeeRole), EmployerHRNMemoryDatabase.EmployerEmployeeRoles);
            StorageBuilder.Add(nameof(EmployerHRBusinessPart), EmployerHRNMemoryDatabase.EmployerHRBusinessParts);
            StorageBuilder.Add(nameof(EmployerHRCenter), EmployerHRNMemoryDatabase.EmployerHRCenters);
            StorageBuilder.Add(nameof(EmployerHREmployee), EmployerHRNMemoryDatabase.EmployerHREmployees);
            StorageBuilder.Add(nameof(EmployerHRRole), EmployerHRNMemoryDatabase.EmployerHRRoles);

            StorageBuilder.Add(nameof(EmployerJCommodity), EmployerJournalNMemoryDatabase.EmployerJCommoditys);
            StorageBuilder.Add(nameof(EmployerJournal), EmployerJournalNMemoryDatabase.EmployerJournals);
            StorageBuilder.Add(nameof(EmployerJournalCenter), EmployerJournalNMemoryDatabase.EmployerJournalCenters);

            StorageBuilder.Add(nameof(EmployerWarehouse), EmployerWarehouseNMemoryDatabase.EmployerWarehouses);
            StorageBuilder.Add(nameof(EmployerWCommodity), EmployerWarehouseNMemoryDatabase.EmployerWCommoditys);
            StorageBuilder.Add(nameof(EmployerSWCommodity), EmployerWarehouseNMemoryDatabase.EmployerSWCommoditys);
            StorageBuilder.Add(nameof(EmployerMWCommodity), EmployerWarehouseNMemoryDatabase.EmployerMWCommoditys);
            StorageBuilder.Add(nameof(EmployerEWCommodity), EmployerWarehouseNMemoryDatabase.EmployerEWCommoditys);
            StorageBuilder.Add(nameof(EmployerDividedTag), EmployerWarehouseNMemoryDatabase.EmployerDividedTags);
            StorageBuilder.Add(nameof(EmployerDotBarcode), EmployerWarehouseNMemoryDatabase.EmployerDotBarcodes);
            StorageBuilder.Add(nameof(EmployerIncomingTag), EmployerWarehouseNMemoryDatabase.EmployerIncomingTags);
            StorageBuilder.Add(nameof(EmployerLoadFrame), EmployerWarehouseNMemoryDatabase.EmployerLoadFrames);
            StorageBuilder.Add(nameof(EmployerWorkingDesk), EmployerWarehouseNMemoryDatabase.EmployerWorkingDesks);

            StorageBuilder.Add(nameof(EmployerTradeCenter), EmployerTradeNMemoryDatabase.EmployerTradeCenters);
            StorageBuilder.Add(nameof(EmployerTCommodity), EmployerTradeNMemoryDatabase.EmployerTCommoditys);
            StorageBuilder.Add(nameof(EmployerSTCommodity), EmployerTradeNMemoryDatabase.EmployerSTCommoditys);
            StorageBuilder.Add(nameof(EmployerMTCommodity), EmployerTradeNMemoryDatabase.EmployerMTCommoditys);
            StorageBuilder.Add(nameof(EmployerETCommodity), EmployerTradeNMemoryDatabase.EmployerETCommoditys);

            StorageBuilder.Add(nameof(EmployerGOC), EmployerGroupOrderNMemoryDatabase.EmployerGOCS);
            StorageBuilder.Add(nameof(EmployerGOCC), EmployerGroupOrderNMemoryDatabase.EmployerGOCCS);
            StorageBuilder.Add(nameof(EmployerSGOC), EmployerGroupOrderNMemoryDatabase.EmployerSGOCS);
            StorageBuilder.Add(nameof(EmployerMGOC), EmployerGroupOrderNMemoryDatabase.EmployerMGOCS);
            StorageBuilder.Add(nameof(EmployerEGOC), EmployerGroupOrderNMemoryDatabase.EmployerEGOCS);

            StorageBuilder.Add(nameof(EmployerOrderCenter), EmployerOrderNMemoryDatabase.EmployerOrderCenters);
            StorageBuilder.Add(nameof(EmployerOCommodity), EmployerOrderNMemoryDatabase.EmployerOCommoditys);
            StorageBuilder.Add(nameof(EmployerSOCommodity), EmployerOrderNMemoryDatabase.EmployerSOCommoditys);
            StorageBuilder.Add(nameof(EmployerMOCommodity), EmployerOrderNMemoryDatabase.EmployerMOCommoditys);
            StorageBuilder.Add(nameof(EmployerEOCommodity), EmployerOrderNMemoryDatabase.EmployerEOCommoditys);

            StorageBuilder.Add(nameof(EmployerEMCommodity), EmployerMarketNMemoryDatabase.EmployerEMCommoditys);
            StorageBuilder.Add(nameof(EmployerSMCommodity), EmployerMarketNMemoryDatabase.EmployerSMCommoditys);
            StorageBuilder.Add(nameof(EmployerMMCommodity), EmployerMarketNMemoryDatabase.EmployerMMCommoditys);
            StorageBuilder.Add(nameof(EmployerMCommodity), EmployerMarketNMemoryDatabase.EmployerMCommoditys);
            StorageBuilder.Add(nameof(EmployerPlatMarket), EmployerMarketNMemoryDatabase.EmployerPlatMarkets);
            StorageBuilder.Add(nameof(EmployerMarket), EmployerMarketNMemoryDatabase.EmployerMarkets);

            StorageBuilder.Add(nameof(EmployerProducter), EmployerProductNMemoryDatabase.EmployerProducters);
            StorageBuilder.Add(nameof(EmployerEPCommodity), EmployerProductNMemoryDatabase.EmployerEPCommoditys);
            StorageBuilder.Add(nameof(EmployerSPCommodity), EmployerProductNMemoryDatabase.EmployerSPCommoditys);
            StorageBuilder.Add(nameof(EmployerMPCommodity), EmployerProductNMemoryDatabase.EmployerMPCommoditys);
            StorageBuilder.Add(nameof(EmployerProductCenter), EmployerProductNMemoryDatabase.EmployerProductCenters);
            StorageBuilder.Add(nameof(EmployerProductLand), EmployerProductNMemoryDatabase.EmployerProductLands);
            StorageBuilder.Add(nameof(EmployerPCommodity), EmployerProductNMemoryDatabase.EmployerPCommoditys);
        }
        protected override void OnValidatorBuilder(ValidatorBuilder ValidatorBuilder)
        {
            ValidatorBuilder.Add(nameof(EmployerEmployeeRole), new EmployerEmployeeRoleValidator());
            ValidatorBuilder.Add(nameof(EmployerHRBusinessPart), new EmployerHRBusinessPartValidator());
            ValidatorBuilder.Add(nameof(EmployerHRCenter), new EmployerHRCenterValidator());
            ValidatorBuilder.Add(nameof(EmployerHREmployee), new EmployerHREmployeeValidator());
            ValidatorBuilder.Add(nameof(EmployerHRRole), new EmployerHRRoleValidator());

            ValidatorBuilder.Add(nameof(EmployerJCommodity), new EmployerJCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerJournal), new EmployerJournalValidator());
            ValidatorBuilder.Add(nameof(EmployerJournalCenter), new EmployerJournalCenterValidator());

            ValidatorBuilder.Add(nameof(EmployerWarehouse), new EmployerWarehouseValidator());
            ValidatorBuilder.Add(nameof(EmployerWCommodity), new EmployerWCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerSWCommodity), new EmployerSWCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerMWCommodity), new EmployerMWCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerEWCommodity), new EmployerEWCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerDividedTag), new EmployerDividedTagValidator());
            ValidatorBuilder.Add(nameof(EmployerDotBarcode), new EmployerDotBarcodeValidator());
            ValidatorBuilder.Add(nameof(EmployerIncomingTag), new EmployerIncomingTagValidator());
            ValidatorBuilder.Add(nameof(EmployerLoadFrame), new EmployerLoadFrameValidator());
            ValidatorBuilder.Add(nameof(EmployerWorkingDesk), new EmployerWorkingDeskValidator());

            ValidatorBuilder.Add(nameof(EmployerTradeCenter), new EmployerTradeCenterValidator());
            ValidatorBuilder.Add(nameof(EmployerTCommodity), new EmployerTCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerSTCommodity), new EmployerSTCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerMTCommodity), new EmployerMTCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerETCommodity), new EmployerETCommodityValidator());

            ValidatorBuilder.Add(nameof(EmployerGOC), new EmployerGOCValidator());
            ValidatorBuilder.Add(nameof(EmployerGOCC), new EmployerGOCCValidator());
            ValidatorBuilder.Add(nameof(EmployerSGOC), new EmployerSGOCValidator());
            ValidatorBuilder.Add(nameof(EmployerMGOC), new EmployerMGOCValidator());
            ValidatorBuilder.Add(nameof(EmployerEGOC), new EmployerEGOCValidator());

            ValidatorBuilder.Add(nameof(EmployerOrderCenter), new EmployerOrderCenterValidator());
            ValidatorBuilder.Add(nameof(EmployerOCommodity), new EmployerOCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerSOCommodity), new EmployerSOCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerMOCommodity), new EmployerMOCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerEOCommodity), new EmployerEOCommodityValidator());

            ValidatorBuilder.Add(nameof(EmployerEMCommodity), new EmployerEMCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerSMCommodity), new EmployerSMCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerMMCommodity), new EmployerMMCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerMCommodity), new EmployerMCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerPlatMarket), new EmployerPlatMarketValidator());
            ValidatorBuilder.Add(nameof(EmployerMarket), new EmployerMarketValidator());

            ValidatorBuilder.Add(nameof(EmployerProducter), new EmployerProducterValidator());
            ValidatorBuilder.Add(nameof(EmployerEPCommodity), new EmployerEPCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerSPCommodity), new EmployerSPCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerMPCommodity), new EmployerMPCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployerProductCenter), new EmployerProductCenterValidator());
            ValidatorBuilder.Add(nameof(EmployerProductLand), new EmployerProductLandValidator());
            ValidatorBuilder.Add(nameof(EmployerPCommodity), new EmployerPCommodityValidator());
        }
    }
}
