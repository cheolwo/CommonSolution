using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket;

namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofSMCommodity
{
    public class SMCommodityPageViewModel<TSStatus> : SStatusPageViewModel<TSStatus> where TSStatus : SMCommodityDTO, new()
    {
        private readonly SMCommodityPostViewModel<TSStatus> _SMCommodityPostViewModel;
        private readonly SMCommodityPutViewModel<TSStatus> _SMCommodityPutViewModel;
        private readonly SMCommodityDeleteViewModel<TSStatus> _SMCommodityDeleteViewModel;
        private readonly SMCommodityGetsViewModel<TSStatus> _SMCommodityGetViewMode;
        public SMCommodityPageViewModel(
            SMCommodityPostViewModel<TSStatus> SMCommodityPostViewModel, 
            SMCommodityPutViewModel<TSStatus> SMCommodityPutViewModel,
            SMCommodityDeleteViewModel<TSStatus> SMCommodityDeleteViewModel, 
            SMCommodityGetsViewModel<TSStatus> SMCommodityGetViewModel)
                                            :base(SMCommodityPostViewModel, SMCommodityPutViewModel, SMCommodityDeleteViewModel, SMCommodityGetViewModel)
        {
            _SMCommodityPostViewModel = SMCommodityPostViewModel;
            _SMCommodityDeleteViewModel = SMCommodityDeleteViewModel;
            _SMCommodityGetViewMode = SMCommodityGetViewModel;
            _SMCommodityPutViewModel = SMCommodityPutViewModel;
        }
    }
}