using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade;

namespace BusinessView.ofViewModels.ofWebApp.ofTrade.ofETCommodity
{
    public class ETCommodityPageViewModel<TEStatus> : EStatusPageViewModel<TEStatus> where TEStatus : ETCommodityDTO, new()
    {
        private readonly ETCommodityPostViewModel<TEStatus> _ETCommodityPostViewModel;
        private readonly ETCommodityPutViewModel<TEStatus> _ETCommodityPutViewModel;
        private readonly ETCommodityDeleteViewModel<TEStatus> _ETCommodityDeleteViewModel;
        private readonly ETCommodityGetsViewModel<TEStatus> _ETCommodityGetViewMode;
        public ETCommodityPageViewModel(
            ETCommodityPostViewModel<TEStatus> ETCommodityPostViewModel, 
            ETCommodityPutViewModel<TEStatus> ETCommodityPutViewModel,
            ETCommodityDeleteViewModel<TEStatus> ETCommodityDeleteViewModel, 
            ETCommodityGetsViewModel<TEStatus> ETCommodityGetViewModel)
                                            :base(ETCommodityPostViewModel, ETCommodityPutViewModel, ETCommodityDeleteViewModel, ETCommodityGetViewModel)
        {
            _ETCommodityPostViewModel = ETCommodityPostViewModel;
            _ETCommodityDeleteViewModel = ETCommodityDeleteViewModel;
            _ETCommodityGetViewMode = ETCommodityGetViewModel;
            _ETCommodityPutViewModel = ETCommodityPutViewModel;
        }
    }
}