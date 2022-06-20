using BusinessData.ofActorService;
using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresendationLayer.ofCommon.ofBuilder;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresendationLayer.ofDTOServices.ofTrade;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployee;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployee;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployee;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;

namespace BusinessData.ofPresendationLayer.ofActorContext.ofEmployee
{
    public class EmployeeOrdererContext : EmployeeActorContext
    {
        public EmployeeOrdererContext(ActorServiceOption options)
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

            serviceBuilder.Add(nameof(EmployeeGOC), new EmployeeGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeGOCC), new EmployeeGOCCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSGOC), new EmployeeSGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMGOC), new EmployeeMGOCService(_options.GroupOrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeEGOC), new EmployeeEGOCService(_options.GroupOrderServiceOptions));

            serviceBuilder.Add(nameof(EmployeeTradeCenter), new EmployeeTradeCenterService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeTCommodity), new EmployeeTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSTCommodity), new EmployeeSTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMTCommodity), new EmployeeMTCommodityService(_options.TradeServiceOptions));
            serviceBuilder.Add(nameof(EmployeeETCommodity), new EmployeeETCommodityService(_options.TradeServiceOptions));

            serviceBuilder.Add(nameof(EmployeeOrderCenter), new EmployeeOrderCenterService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeOCommodity), new EmployeeOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeSOCommodity), new EmployeeSOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeMOCommodity), new EmployeeMOCommodityService(_options.OrderServiceOptions));
            serviceBuilder.Add(nameof(EmployeeEOCommodity), new EmployeeEOCommodityService(_options.OrderServiceOptions));
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {

        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {

        }
    }
}
