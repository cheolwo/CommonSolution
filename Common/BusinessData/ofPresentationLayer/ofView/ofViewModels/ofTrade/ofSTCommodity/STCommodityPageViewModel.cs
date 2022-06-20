using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade;

namespace BusinessView.ofViewModels.ofWebApp.ofTrade.ofSTCommodity
{
    public class STCommodityPageViewModel<TSStatus> : SStatusPageViewModel<TSStatus> where TSStatus : STCommodityDTO, new()
    {
        private readonly STCommodityPostViewModel<TSStatus> _STCommodityPostViewModel;
        private readonly STCommodityPutViewModel<TSStatus> _STCommodityPutViewModel;
        private readonly STCommodityDeleteViewModel<TSStatus> _STCommodityDeleteViewModel;
        private readonly STCommodityGetsViewModel<TSStatus> _STCommodityGetViewMode;
        public STCommodityPageViewModel(
            STCommodityPostViewModel<TSStatus> STCommodityPostViewModel, 
            STCommodityPutViewModel<TSStatus> STCommodityPutViewModel,
            STCommodityDeleteViewModel<TSStatus> STCommodityDeleteViewModel, 
            STCommodityGetsViewModel<TSStatus> STCommodityGetViewModel)
                                            :base(STCommodityPostViewModel, STCommodityPutViewModel, STCommodityDeleteViewModel, STCommodityGetViewModel)
        {
            _STCommodityPostViewModel = STCommodityPostViewModel;
            _STCommodityDeleteViewModel = STCommodityDeleteViewModel;
            _STCommodityGetViewMode = STCommodityGetViewModel;
            _STCommodityPutViewModel = STCommodityPutViewModel;
        }
    }
}