using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder;

namespace BusinessView.ofViewModels.ofWebApp.ofOrder.ofEOCommodity
{
    public class EOCommodityPageViewModel<TEStatus> : EStatusPageViewModel<TEStatus> where TEStatus : EOCommodityDTO, new()
    {
        private readonly EOCommodityPostViewModel<TEStatus> _EOCommodityPostViewModel;
        private readonly EOCommodityPutViewModel<TEStatus> _EOCommodityPutViewModel;
        private readonly EOCommodityDeleteViewModel<TEStatus> _EOCommodityDeleteViewModel;
        private readonly EOCommodityGetsViewModel<TEStatus> _EOCommodityGetViewMode;
        public EOCommodityPageViewModel(
            EOCommodityPostViewModel<TEStatus> EOCommodityPostViewModel, 
            EOCommodityPutViewModel<TEStatus> EOCommodityPutViewModel,
            EOCommodityDeleteViewModel<TEStatus> EOCommodityDeleteViewModel, 
            EOCommodityGetsViewModel<TEStatus> EOCommodityGetViewModel)
                                            :base(EOCommodityPostViewModel, EOCommodityPutViewModel, EOCommodityDeleteViewModel, EOCommodityGetViewModel)
        {
            _EOCommodityPostViewModel = EOCommodityPostViewModel;
            _EOCommodityDeleteViewModel = EOCommodityDeleteViewModel;
            _EOCommodityGetViewMode = EOCommodityGetViewModel;
            _EOCommodityPutViewModel = EOCommodityPutViewModel;
        }
    }
}