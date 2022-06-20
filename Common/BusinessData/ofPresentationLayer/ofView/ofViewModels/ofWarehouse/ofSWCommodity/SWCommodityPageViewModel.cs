using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessView.ofViewModels.ofGeneric;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofSWCommodity
{
    public class SWCommodityPageViewModel<TSStatus> : SStatusPageViewModel<TSStatus> where TSStatus : SWCommodityDTO, new()
    {
        private readonly SWCommodityPostViewModel<TSStatus> _SWCommodityPostViewModel;
        private readonly SWCommodityPutViewModel<TSStatus> _SWCommodityPutViewModel;
        private readonly SWCommodityDeleteViewModel<TSStatus> _SWCommodityDeleteViewModel;
        private readonly SWCommodityGetsViewModel<TSStatus> _SWCommodityGetViewMode;
        public SWCommodityPageViewModel(
            SWCommodityPostViewModel<TSStatus> SWCommodityPostViewModel, 
            SWCommodityPutViewModel<TSStatus> SWCommodityPutViewModel,
            SWCommodityDeleteViewModel<TSStatus> SWCommodityDeleteViewModel, 
            SWCommodityGetsViewModel<TSStatus> SWCommodityGetViewModel)
                                            :base(SWCommodityPostViewModel, SWCommodityPutViewModel, SWCommodityDeleteViewModel, SWCommodityGetViewModel)
        {
            _SWCommodityPostViewModel = SWCommodityPostViewModel;
            _SWCommodityDeleteViewModel = SWCommodityDeleteViewModel;
            _SWCommodityGetViewMode = SWCommodityGetViewModel;
            _SWCommodityPutViewModel = SWCommodityPutViewModel;
        }
    }
}