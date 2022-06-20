using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket;

namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofPlatMarket
{
    public class PlatMarketPageViewModel<TCenter> : CenterPageViewModel<TCenter> where TCenter : PlatMarketDTO, new()
    {
        private readonly PlatMarketPostViewModel<TCenter> _PlatMarketPostViewModel;
        private readonly PlatMarketPutViewModel<TCenter> _PlatMarketPutViewModel;
        private readonly PlatMarketDeleteViewModel<TCenter> _PlatMarketDeleteViewModel;
        private readonly PlatMarketGetsViewModel<TCenter> _PlatMarketGetViewMode;
        public PlatMarketPageViewModel(
            PlatMarketPostViewModel<TCenter> PlatMarketPostViewModel, 
            PlatMarketPutViewModel<TCenter> PlatMarketPutViewModel,
            PlatMarketDeleteViewModel<TCenter> PlatMarketDeleteViewModel, 
            PlatMarketGetsViewModel<TCenter> PlatMarketGetViewModel)
                                            :base(PlatMarketPostViewModel, PlatMarketPutViewModel, PlatMarketDeleteViewModel, PlatMarketGetViewModel)
        {
            _PlatMarketPostViewModel = PlatMarketPostViewModel;
            _PlatMarketDeleteViewModel = PlatMarketDeleteViewModel;
            _PlatMarketGetViewMode = PlatMarketGetViewModel;
            _PlatMarketPutViewModel = PlatMarketPutViewModel;
        }
    }
}