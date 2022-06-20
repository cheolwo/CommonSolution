using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder;

namespace BusinessView.ofViewModels.ofWebApp.ofOrder.ofMOCommodity
{
    public class MOCommodityPageViewModel<TMStatus> : MStatusPageViewModel<TMStatus> where TMStatus : MOCommodityDTO, new()
    {
        private readonly MOCommodityPostViewModel<TMStatus> _MOCommodityPostViewModel;
        private readonly MOCommodityPutViewModel<TMStatus> _MOCommodityPutViewModel;
        private readonly MOCommodityDeleteViewModel<TMStatus> _MOCommodityDeleteViewModel;
        private readonly MOCommodityGetsViewModel<TMStatus> _MOCommodityGetViewMode;
        public MOCommodityPageViewModel(
            MOCommodityPostViewModel<TMStatus> MOCommodityPostViewModel, 
            MOCommodityPutViewModel<TMStatus> MOCommodityPutViewModel,
            MOCommodityDeleteViewModel<TMStatus> MOCommodityDeleteViewModel, 
            MOCommodityGetsViewModel<TMStatus> MOCommodityGetViewModel)
                                            :base(MOCommodityPostViewModel, MOCommodityPutViewModel, MOCommodityDeleteViewModel, MOCommodityGetViewModel)
        {
            _MOCommodityPostViewModel = MOCommodityPostViewModel;
            _MOCommodityDeleteViewModel = MOCommodityDeleteViewModel;
            _MOCommodityGetViewMode = MOCommodityGetViewModel;
            _MOCommodityPutViewModel = MOCommodityPutViewModel;
        }
    }
}