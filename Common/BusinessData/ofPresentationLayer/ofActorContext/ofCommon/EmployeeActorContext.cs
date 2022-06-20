using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployee;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee;
using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployee;
using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployee;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployee;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployee;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee;
using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresendationLayer.ofDTOServices.ofTrade;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresendationLayer.ofCommon.ofBuilder;
using BusinessData.ofActorService;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployee.ofTrade;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployee.ofGroupOrder;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployee.ofOrder;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployee.ofMarket;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployee.ofProduct;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployee.ofWarehouse;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployee.ofJournal;
using BusinessData.ofPresentationLayer.ofValidator.ofEmployee.ofHR;
using BusinessData.ofPresentationLayer.ofStorage.ofEmployee;

namespace BusinessData.ofPresendationLayer.ofActorContext.ofCommon
{
    public class EmployeeActorContext : UserActorContext
    {
        public EmployeeActorContext(ActorServiceOption options)
        :base(options)
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
            serviceBuilder.Add(nameof(EmployeeEmployeeRole), new EmployeeEmployeeRoleService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(EmployeeHRBusinessPart), new EmployeeHRBusinessPartService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(EmployeeHRCenter), new EmployeeHRCenterService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(EmployeeHREmployee), new EmployeeHREmployeeService(_options.HRServiceOptions));
            serviceBuilder.Add(nameof(EmployeeHRRole), new EmployeeHRRoleService(_options.HRServiceOptions));

            serviceBuilder.Add(nameof(EmployeeJCommodity), new EmployeeJCommodityService(_options.JournalServiceOptions));
            serviceBuilder.Add(nameof(EmployeeJournal), new EmployeeJournalService(_options.JournalServiceOptions));
            serviceBuilder.Add(nameof(EmployeeJournalCenter), new EmployeeJournalCenterService(_options.JournalServiceOptions));

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

            serviceBuilder.Add(nameof(EmployeeTradeCenter), new EmployeeTradeCenterService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeTCommodity), new EmployeeTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSTCommodity), new EmployeeSTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMTCommodity), new EmployeeMTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeETCommodity), new EmployeeETCommodityService(_options.TradeServiceOptions));

            serviceBuilder.Add(nameof(EmployeeGOC), new EmployeeGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeGOCC), new EmployeeGOCCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSGOC), new EmployeeSGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMGOC), new EmployeeMGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeEGOC), new EmployeeEGOCService(_options.GroupOrderServiceOptions));

            serviceBuilder.Add(nameof(EmployeeOrderCenter), new EmployeeOrderCenterService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeOCommodity), new EmployeeOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSOCommodity), new EmployeeSOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMOCommodity), new EmployeeMOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeEOCommodity), new EmployeeEOCommodityService(_options.OrderServiceOptions));

            serviceBuilder.Add(nameof(EmployeeEMCommodity), new EmployeeEMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSMCommodity), new EmployeeSMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMMCommodity), new EmployeeMMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMCommodity), new EmployeeMCommodityService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployeePlatMarket), new EmployeePlatMarketService(_options.MarketServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMarket), new EmployeeMarketService(_options.MarketServiceOptions));

            serviceBuilder.Add(nameof(EmployeeProducter), new EmployeeProducterService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployeeEPCommodity), new EmployeeEPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSPCommodity), new EmployeeSPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMPCommodity), new EmployeeMPCommodityService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployeeProductCenter), new EmployeeProductCenterService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployeeProductLand), new EmployeeProductLandService(_options.ProductServiceOptions));
            serviceBuilder.Add(nameof(EmployeePCommodity), new EmployeePCommodityService(_options.ProductServiceOptions));
        }
        protected override void OnStrorageBuilder(StorageBuilder StorageBuilder) 
        {
            EmployeeGroupOrderNMemoryDatabase EmployeeGroupOrderNMemoryDatabase = new();
            EmployeeHRNMemoryDatabase EmployeeHRNMemoryDatabase = new();
            EmployeeJournalNMemoryDatabase EmployeeJournalNMemoryDatabase = new();
            EmployeeMarketNMemoryDatabase EmployeeMarketNMemoryDatabase = new();
            EmployeeOrderNMemoryDatabase EmployeeOrderNMemoryDatabase = new();
            EmployeeProductNMemoryDatabase EmployeeProductNMemoryDatabase = new();
            EmployeeTradeNMemoryDatabase EmployeeTradeNMemoryDatabase = new();
            EmployeeWarehouseNMemoryDatabase EmployeeWarehouseNMemoryDatabase = new();

            StorageBuilder.Add(nameof(EmployeeEmployeeRole), EmployeeHRNMemoryDatabase.EmployeeEmployeeRoles);
            StorageBuilder.Add(nameof(EmployeeHRBusinessPart), EmployeeHRNMemoryDatabase.EmployeeHRBusinessParts);
            StorageBuilder.Add(nameof(EmployeeHRCenter), EmployeeHRNMemoryDatabase.EmployeeHRCenters);
            StorageBuilder.Add(nameof(EmployeeHREmployee), EmployeeHRNMemoryDatabase.EmployeeHREmployees);
            StorageBuilder.Add(nameof(EmployeeHRRole), EmployeeHRNMemoryDatabase.EmployeeHRRoles);

            StorageBuilder.Add(nameof(EmployeeJCommodity), EmployeeJournalNMemoryDatabase.EmployeeJCommoditys);
            StorageBuilder.Add(nameof(EmployeeJournal), EmployeeJournalNMemoryDatabase.EmployeeJournals);
            StorageBuilder.Add(nameof(EmployeeJournalCenter), EmployeeJournalNMemoryDatabase.EmployeeJournalCenters);

            StorageBuilder.Add(nameof(EmployeeWarehouse), EmployeeWarehouseNMemoryDatabase.EmployeeWarehouses);
            StorageBuilder.Add(nameof(EmployeeWCommodity), EmployeeWarehouseNMemoryDatabase.EmployeeWCommoditys);
            StorageBuilder.Add(nameof(EmployeeSWCommodity), EmployeeWarehouseNMemoryDatabase.EmployeeSWCommoditys);
            StorageBuilder.Add(nameof(EmployeeMWCommodity), EmployeeWarehouseNMemoryDatabase.EmployeeMWCommoditys);
            StorageBuilder.Add(nameof(EmployeeEWCommodity), EmployeeWarehouseNMemoryDatabase.EmployeeEWCommoditys);
            StorageBuilder.Add(nameof(EmployeeDividedTag), EmployeeWarehouseNMemoryDatabase.EmployeeDividedTags);
            StorageBuilder.Add(nameof(EmployeeDotBarcode), EmployeeWarehouseNMemoryDatabase.EmployeeDotBarcodes);
            StorageBuilder.Add(nameof(EmployeeIncomingTag), EmployeeWarehouseNMemoryDatabase.EmployeeIncomingTags);
            StorageBuilder.Add(nameof(EmployeeLoadFrame), EmployeeWarehouseNMemoryDatabase.EmployeeLoadFrames);
            StorageBuilder.Add(nameof(EmployeeWorkingDesk), EmployeeWarehouseNMemoryDatabase.EmployeeWorkingDesks);

            StorageBuilder.Add(nameof(EmployeeTradeCenter), EmployeeTradeNMemoryDatabase.EmployeeTradeCenters);
            StorageBuilder.Add(nameof(EmployeeTCommodity), EmployeeTradeNMemoryDatabase.EmployeeTCommoditys);
            StorageBuilder.Add(nameof(EmployeeSTCommodity), EmployeeTradeNMemoryDatabase.EmployeeSTCommoditys);
            StorageBuilder.Add(nameof(EmployeeMTCommodity), EmployeeTradeNMemoryDatabase.EmployeeMTCommoditys);
            StorageBuilder.Add(nameof(EmployeeETCommodity), EmployeeTradeNMemoryDatabase.EmployeeETCommoditys);

            StorageBuilder.Add(nameof(EmployeeGOC), EmployeeGroupOrderNMemoryDatabase.EmployeeGOCS);
            StorageBuilder.Add(nameof(EmployeeGOCC), EmployeeGroupOrderNMemoryDatabase.EmployeeGOCCS);
            StorageBuilder.Add(nameof(EmployeeSGOC), EmployeeGroupOrderNMemoryDatabase.EmployeeSGOCS);
            StorageBuilder.Add(nameof(EmployeeMGOC), EmployeeGroupOrderNMemoryDatabase.EmployeeMGOCS);
            StorageBuilder.Add(nameof(EmployeeEGOC), EmployeeGroupOrderNMemoryDatabase.EmployeeEGOCS);

            StorageBuilder.Add(nameof(EmployeeOrderCenter), EmployeeOrderNMemoryDatabase.EmployeeOrderCenters);
            StorageBuilder.Add(nameof(EmployeeOCommodity), EmployeeOrderNMemoryDatabase.EmployeeOCommoditys);
            StorageBuilder.Add(nameof(EmployeeSOCommodity), EmployeeOrderNMemoryDatabase.EmployeeSOCommoditys);
            StorageBuilder.Add(nameof(EmployeeMOCommodity), EmployeeOrderNMemoryDatabase.EmployeeMOCommoditys);
            StorageBuilder.Add(nameof(EmployeeEOCommodity), EmployeeOrderNMemoryDatabase.EmployeeEOCommoditys);

            StorageBuilder.Add(nameof(EmployeeEMCommodity), EmployeeMarketNMemoryDatabase.EmployeeEMCommoditys);
            StorageBuilder.Add(nameof(EmployeeSMCommodity), EmployeeMarketNMemoryDatabase.EmployeeSMCommoditys);
            StorageBuilder.Add(nameof(EmployeeMMCommodity), EmployeeMarketNMemoryDatabase.EmployeeMMCommoditys);
            StorageBuilder.Add(nameof(EmployeeMCommodity), EmployeeMarketNMemoryDatabase.EmployeeMCommoditys);
            StorageBuilder.Add(nameof(EmployeePlatMarket), EmployeeMarketNMemoryDatabase.EmployeePlatMarkets);
            StorageBuilder.Add(nameof(EmployeeMarket), EmployeeMarketNMemoryDatabase.EmployeeMarkets);

            StorageBuilder.Add(nameof(EmployeeProducter), EmployeeProductNMemoryDatabase.EmployeeProducters);
            StorageBuilder.Add(nameof(EmployeeEPCommodity), EmployeeProductNMemoryDatabase.EmployeeEPCommoditys);
            StorageBuilder.Add(nameof(EmployeeSPCommodity), EmployeeProductNMemoryDatabase.EmployeeSPCommoditys);
            StorageBuilder.Add(nameof(EmployeeMPCommodity), EmployeeProductNMemoryDatabase.EmployeeMPCommoditys);
            StorageBuilder.Add(nameof(EmployeeProductCenter), EmployeeProductNMemoryDatabase.EmployeeProductCenters);
            StorageBuilder.Add(nameof(EmployeeProductLand), EmployeeProductNMemoryDatabase.EmployeeProductLands);
            StorageBuilder.Add(nameof(EmployeePCommodity), EmployeeProductNMemoryDatabase.EmployeePCommoditys);
        }
        protected override void OnValidatorBuilder(ValidatorBuilder ValidatorBuilder) 
        {
            ValidatorBuilder.Add(nameof(EmployeeEmployeeRole), new EmployeeEmployeeRoleValidator());
            ValidatorBuilder.Add(nameof(EmployeeHRBusinessPart), new EmployeeHRBusinessPartValidator());
            ValidatorBuilder.Add(nameof(EmployeeHRCenter), new EmployeeHRCenterValidator());
            ValidatorBuilder.Add(nameof(EmployeeHREmployee), new EmployeeHREmployeeValidator());
            ValidatorBuilder.Add(nameof(EmployeeHRRole), new EmployeeHRRoleValidator());

            ValidatorBuilder.Add(nameof(EmployeeJCommodity), new EmployeeJCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeJournal), new EmployeeJournalValidator());
            ValidatorBuilder.Add(nameof(EmployeeJournalCenter), new EmployeeJournalCenterValidator());

            ValidatorBuilder.Add(nameof(EmployeeWarehouse), new EmployeeWarehouseValidator());
            ValidatorBuilder.Add(nameof(EmployeeWCommodity), new EmployeeWCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeSWCommodity), new EmployeeSWCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeMWCommodity), new EmployeeMWCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeEWCommodity), new EmployeeEWCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeDividedTag), new EmployeeDividedTagValidator());
            ValidatorBuilder.Add(nameof(EmployeeDotBarcode), new EmployeeDotBarcodeValidator());
            ValidatorBuilder.Add(nameof(EmployeeIncomingTag), new EmployeeIncomingTagValidator());
            ValidatorBuilder.Add(nameof(EmployeeLoadFrame), new EmployeeLoadFrameValidator());
            ValidatorBuilder.Add(nameof(EmployeeWorkingDesk), new EmployeeWorkingDeskValidator());

            ValidatorBuilder.Add(nameof(EmployeeTradeCenter), new EmployeeTradeCenterValidator());
            ValidatorBuilder.Add(nameof(EmployeeTCommodity), new EmployeeTCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeSTCommodity), new EmployeeSTCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeMTCommodity), new EmployeeMTCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeETCommodity), new EmployeeETCommodityValidator());

            ValidatorBuilder.Add(nameof(EmployeeGOC), new EmployeeGOCValidator());
            ValidatorBuilder.Add(nameof(EmployeeGOCC), new EmployeeGOCCValidator());
            ValidatorBuilder.Add(nameof(EmployeeSGOC), new EmployeeSGOCValidator());
            ValidatorBuilder.Add(nameof(EmployeeMGOC), new EmployeeMGOCValidator());
            ValidatorBuilder.Add(nameof(EmployeeEGOC), new EmployeeEGOCValidator());

            ValidatorBuilder.Add(nameof(EmployeeOrderCenter), new EmployeeOrderCenterValidator());
            ValidatorBuilder.Add(nameof(EmployeeOCommodity), new EmployeeOCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeSOCommodity), new EmployeeSOCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeMOCommodity), new EmployeeMOCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeEOCommodity), new EmployeeEOCommodityValidator());

            ValidatorBuilder.Add(nameof(EmployeeEMCommodity), new EmployeeEMCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeSMCommodity), new EmployeeSMCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeMMCommodity), new EmployeeMMCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeMCommodity), new EmployeeMCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeePlatMarket), new EmployeePlatMarketValidator());
            ValidatorBuilder.Add(nameof(EmployeeMarket), new EmployeeMarketValidator());

            ValidatorBuilder.Add(nameof(EmployeeProducter), new EmployeeProducterValidator());
            ValidatorBuilder.Add(nameof(EmployeeEPCommodity), new EmployeeEPCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeSPCommodity), new EmployeeSPCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeMPCommodity), new EmployeeMPCommodityValidator());
            ValidatorBuilder.Add(nameof(EmployeeProductCenter), new EmployeeProductCenterValidator());
            ValidatorBuilder.Add(nameof(EmployeeProductLand), new EmployeeProductLandValidator());
            ValidatorBuilder.Add(nameof(EmployeePCommodity), new EmployeePCommodityValidator());
        }
    }
}
