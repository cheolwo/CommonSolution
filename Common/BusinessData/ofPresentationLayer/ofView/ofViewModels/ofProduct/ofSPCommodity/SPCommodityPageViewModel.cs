using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;

namespace BusinessView.ofViewModels.ofWebApp.ofProduct.ofSPCommodity
{
    public class SPCommodityPageViewModel<TSStatus> : SStatusPageViewModel<TSStatus> where TSStatus : SPCommodityDTO, new()
    {
        private readonly SPCommodityPostViewModel<TSStatus> _SPCommodityPostViewModel;
        private readonly SPCommodityPutViewModel<TSStatus> _SPCommodityPutViewModel;
        private readonly SPCommodityDeleteViewModel<TSStatus> _SPCommodityDeleteViewModel;
        private readonly SPCommodityGetsViewModel<TSStatus> _SPCommodityGetViewMode;
        public SPCommodityPageViewModel(
            SPCommodityPostViewModel<TSStatus> SPCommodityPostViewModel, 
            SPCommodityPutViewModel<TSStatus> SPCommodityPutViewModel,
            SPCommodityDeleteViewModel<TSStatus> SPCommodityDeleteViewModel, 
            SPCommodityGetsViewModel<TSStatus> SPCommodityGetViewModel)
                                            :base(SPCommodityPostViewModel, SPCommodityPutViewModel, SPCommodityDeleteViewModel, SPCommodityGetViewModel)
        {
            _SPCommodityPostViewModel = SPCommodityPostViewModel;
            _SPCommodityDeleteViewModel = SPCommodityDeleteViewModel;
            _SPCommodityGetViewMode = SPCommodityGetViewModel;
            _SPCommodityPutViewModel = SPCommodityPutViewModel;
        }
    }
}