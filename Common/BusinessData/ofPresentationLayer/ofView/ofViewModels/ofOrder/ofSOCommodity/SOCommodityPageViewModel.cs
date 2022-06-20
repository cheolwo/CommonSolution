using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder;

namespace BusinessView.ofViewModels.ofWebApp.ofOrder.ofSOCommodity
{
    public class SOCommodityPageViewModel<TSStatus> : SStatusPageViewModel<TSStatus> where TSStatus : SOCommodityDTO, new()
    {
        private readonly SOCommodityPostViewModel<TSStatus> _SOCommodityPostViewModel;
        private readonly SOCommodityPutViewModel<TSStatus> _SOCommodityPutViewModel;
        private readonly SOCommodityDeleteViewModel<TSStatus> _SOCommodityDeleteViewModel;
        private readonly SOCommodityGetsViewModel<TSStatus> _SOCommodityGetViewMode;
        public SOCommodityPageViewModel(
            SOCommodityPostViewModel<TSStatus> SOCommodityPostViewModel, 
            SOCommodityPutViewModel<TSStatus> SOCommodityPutViewModel,
            SOCommodityDeleteViewModel<TSStatus> SOCommodityDeleteViewModel, 
            SOCommodityGetsViewModel<TSStatus> SOCommodityGetViewModel)
                                            :base(SOCommodityPostViewModel, SOCommodityPutViewModel, SOCommodityDeleteViewModel, SOCommodityGetViewModel)
        {
            _SOCommodityPostViewModel = SOCommodityPostViewModel;
            _SOCommodityDeleteViewModel = SOCommodityDeleteViewModel;
            _SOCommodityGetViewMode = SOCommodityGetViewModel;
            _SOCommodityPutViewModel = SOCommodityPutViewModel;
        }
    }
}