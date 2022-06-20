using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket;

namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofMarket
{
    public class MarketPageViewModel<TCenter> : CenterPageViewModel<TCenter> where TCenter : MarketDTO, new()
    {
        private readonly MarketPostViewModel<TCenter> _MarketPostViewModel;
        private readonly MarketPutViewModel<TCenter> _MarketPutViewModel;
        private readonly MarketDeleteViewModel<TCenter> _MarketDeleteViewModel;
        private readonly MarketGetsViewModel<TCenter> _MarketGetViewMode;
        public MarketPageViewModel(
            MarketPostViewModel<TCenter> MarketPostViewModel, 
            MarketPutViewModel<TCenter> MarketPutViewModel,
            MarketDeleteViewModel<TCenter> MarketDeleteViewModel, 
            MarketGetsViewModel<TCenter> MarketGetViewModel)
                                            :base(MarketPostViewModel, MarketPutViewModel, MarketDeleteViewModel, MarketGetViewModel)
        {
            _MarketPostViewModel = MarketPostViewModel;
            _MarketDeleteViewModel = MarketDeleteViewModel;
            _MarketGetViewMode = MarketGetViewModel;
            _MarketPutViewModel = MarketPutViewModel;
        }
    }
}