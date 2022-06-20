using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade;

namespace BusinessView.ofViewModels.ofWebApp.ofTrade.ofTCommodity
{
    public class TCommodityPageViewModel<TCommodity> : CommodityPageViewModel<TCommodity> where TCommodity : TCommodityDTO, new()
    {
        private readonly TCommodityPostViewModel<TCommodity> _TCommodityPostViewModel;
        private readonly TCommodityPutViewModel<TCommodity> _TCommodityPutViewModel;
        private readonly TCommodityDeleteViewModel<TCommodity> _TCommodityDeleteViewModel;
        private readonly TCommodityGetsViewModel<TCommodity> _TCommodityGetViewMode;
        public TCommodityPageViewModel(
            TCommodityPostViewModel<TCommodity> TCommodityPostViewModel, 
            TCommodityPutViewModel<TCommodity> TCommodityPutViewModel,
            TCommodityDeleteViewModel<TCommodity> TCommodityDeleteViewModel, 
            TCommodityGetsViewModel<TCommodity> TCommodityGetViewModel)
                                            :base(TCommodityPostViewModel, TCommodityPutViewModel, TCommodityDeleteViewModel, TCommodityGetViewModel)
        {
            _TCommodityPostViewModel = TCommodityPostViewModel;
            _TCommodityDeleteViewModel = TCommodityDeleteViewModel;
            _TCommodityGetViewMode = TCommodityGetViewModel;
            _TCommodityPutViewModel = TCommodityPutViewModel;
        }
    }
}