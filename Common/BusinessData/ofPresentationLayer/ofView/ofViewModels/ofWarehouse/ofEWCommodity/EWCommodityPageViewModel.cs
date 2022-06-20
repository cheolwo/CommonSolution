using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofEWCommodity
{
    public class EWCommodityPageViewModel<TEStatus> : EStatusPageViewModel<TEStatus> where TEStatus : EWCommodityDTO, new()
    {
        private readonly EWCommodityPostViewModel<TEStatus> _EWCommodityPostViewModel;
        private readonly EWCommodityPutViewModel<TEStatus> _EWCommodityPutViewModel;
        private readonly EWCommodityDeleteViewModel<TEStatus> _EWCommodityDeleteViewModel;
        private readonly EWCommodityGetsViewModel<TEStatus> _EWCommodityGetViewMode;
        public EWCommodityPageViewModel(
            EWCommodityPostViewModel<TEStatus> EWCommodityPostViewModel, 
            EWCommodityPutViewModel<TEStatus> EWCommodityPutViewModel,
            EWCommodityDeleteViewModel<TEStatus> EWCommodityDeleteViewModel, 
            EWCommodityGetsViewModel<TEStatus> EWCommodityGetViewModel)
                                            :base(EWCommodityPostViewModel, EWCommodityPutViewModel, EWCommodityDeleteViewModel, EWCommodityGetViewModel)
        {
            _EWCommodityPostViewModel = EWCommodityPostViewModel;
            _EWCommodityDeleteViewModel = EWCommodityDeleteViewModel;
            _EWCommodityGetViewMode = EWCommodityGetViewModel;
            _EWCommodityPutViewModel = EWCommodityPutViewModel;
        }
    }
}