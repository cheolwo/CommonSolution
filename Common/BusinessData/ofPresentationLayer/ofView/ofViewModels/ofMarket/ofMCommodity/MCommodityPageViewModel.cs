using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket;

namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofMCommodity
{
    public class MCommodityPageViewModel<TCommodity> : CommodityPageViewModel<TCommodity> where TCommodity : MCommodityDTO, new()
    {
        private readonly MCommodityPostViewModel<TCommodity> _MCommodityPostViewModel;
        private readonly MCommodityPutViewModel<TCommodity> _MCommodityPutViewModel;
        private readonly MCommodityDeleteViewModel<TCommodity> _MCommodityDeleteViewModel;
        private readonly MCommodityGetsViewModel<TCommodity> _MCommodityGetViewMode;
        public MCommodityPageViewModel(
            MCommodityPostViewModel<TCommodity> MCommodityPostViewModel, 
            MCommodityPutViewModel<TCommodity> MCommodityPutViewModel,
            MCommodityDeleteViewModel<TCommodity> MCommodityDeleteViewModel, 
            MCommodityGetsViewModel<TCommodity> MCommodityGetViewModel)
                                            :base(MCommodityPostViewModel, MCommodityPutViewModel, MCommodityDeleteViewModel, MCommodityGetViewModel)
        {
            _MCommodityPostViewModel = MCommodityPostViewModel;
            _MCommodityDeleteViewModel = MCommodityDeleteViewModel;
            _MCommodityGetViewMode = MCommodityGetViewModel;
            _MCommodityPutViewModel = MCommodityPutViewModel;
        }
    }
}