using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade;

namespace BusinessView.ofViewModels.ofWebApp.ofTrade.ofTradeCenter
{
    public class TradeCenterPageViewModel<TCenter> : CenterPageViewModel<TCenter> where TCenter : TradeCenterDTO, new()
    {
        private readonly TradeCenterPostViewModel<TCenter> _TradeCenterPostViewModel;
        private readonly TradeCenterPutViewModel<TCenter> _TradeCenterPutViewModel;
        private readonly TradeCenterDeleteViewModel<TCenter> _TradeCenterDeleteViewModel;
        private readonly TradeCenterGetsViewModel<TCenter> _TradeCenterGetViewMode;
        public TradeCenterPageViewModel(
            TradeCenterPostViewModel<TCenter> TradeCenterPostViewModel, 
            TradeCenterPutViewModel<TCenter> TradeCenterPutViewModel,
            TradeCenterDeleteViewModel<TCenter> TradeCenterDeleteViewModel, 
            TradeCenterGetsViewModel<TCenter> TradeCenterGetViewModel)
                                            :base(TradeCenterPostViewModel, TradeCenterPutViewModel, TradeCenterDeleteViewModel, TradeCenterGetViewModel)
        {
            _TradeCenterPostViewModel = TradeCenterPostViewModel;
            _TradeCenterDeleteViewModel = TradeCenterDeleteViewModel;
            _TradeCenterGetViewMode = TradeCenterGetViewModel;
            _TradeCenterPutViewModel = TradeCenterPutViewModel;
        }
    }
}