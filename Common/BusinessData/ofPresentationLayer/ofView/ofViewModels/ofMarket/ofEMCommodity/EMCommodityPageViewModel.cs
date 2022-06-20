using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket;

namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofEMCommodity
{
    public class EMCommodityPageViewModel<TEStatus> : EStatusPageViewModel<TEStatus> where TEStatus : EMCommodityDTO, new()
    {
        private readonly EMCommodityPostViewModel<TEStatus> _EMCommodityPostViewModel;
        private readonly EMCommodityPutViewModel<TEStatus> _EMCommodityPutViewModel;
        private readonly EMCommodityDeleteViewModel<TEStatus> _EMCommodityDeleteViewModel;
        private readonly EMCommodityGetsViewModel<TEStatus> _EMCommodityGetViewMode;
        public EMCommodityPageViewModel(
            EMCommodityPostViewModel<TEStatus> EMCommodityPostViewModel, 
            EMCommodityPutViewModel<TEStatus> EMCommodityPutViewModel,
            EMCommodityDeleteViewModel<TEStatus> EMCommodityDeleteViewModel, 
            EMCommodityGetsViewModel<TEStatus> EMCommodityGetViewModel)
                                            :base(EMCommodityPostViewModel, EMCommodityPutViewModel, EMCommodityDeleteViewModel, EMCommodityGetViewModel)
        {
            _EMCommodityPostViewModel = EMCommodityPostViewModel;
            _EMCommodityDeleteViewModel = EMCommodityDeleteViewModel;
            _EMCommodityGetViewMode = EMCommodityGetViewModel;
            _EMCommodityPutViewModel = EMCommodityPutViewModel;
        }
    }
}