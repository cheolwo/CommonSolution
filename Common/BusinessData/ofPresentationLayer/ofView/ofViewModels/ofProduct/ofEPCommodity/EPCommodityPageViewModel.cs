using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;

namespace BusinessView.ofViewModels.ofWebApp.ofProduct.ofEPCommodity
{
    public class EPCommodityPageViewModel<TEStatus> : EStatusPageViewModel<TEStatus> where TEStatus : EPCommodityDTO, new()
    {
        private readonly EPCommodityPostViewModel<TEStatus> _EPCommodityPostViewModel;
        private readonly EPCommodityPutViewModel<TEStatus> _EPCommodityPutViewModel;
        private readonly EPCommodityDeleteViewModel<TEStatus> _EPCommodityDeleteViewModel;
        private readonly EPCommodityGetsViewModel<TEStatus> _EPCommodityGetViewMode;
        public EPCommodityPageViewModel(
            EPCommodityPostViewModel<TEStatus> EPCommodityPostViewModel, 
            EPCommodityPutViewModel<TEStatus> EPCommodityPutViewModel,
            EPCommodityDeleteViewModel<TEStatus> EPCommodityDeleteViewModel, 
            EPCommodityGetsViewModel<TEStatus> EPCommodityGetViewModel)
                                            :base(EPCommodityPostViewModel, EPCommodityPutViewModel, EPCommodityDeleteViewModel, EPCommodityGetViewModel)
        {
            _EPCommodityPostViewModel = EPCommodityPostViewModel;
            _EPCommodityDeleteViewModel = EPCommodityDeleteViewModel;
            _EPCommodityGetViewMode = EPCommodityGetViewModel;
            _EPCommodityPutViewModel = EPCommodityPutViewModel;
        }
    }
}