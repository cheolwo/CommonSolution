using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;

namespace BusinessView.ofViewModels.ofWebApp.ofProduct.ofMPCommodity
{
    public class MPCommodityPageViewModel<TMStatus> : MStatusPageViewModel<TMStatus> where TMStatus : MPCommodityDTO, new()
    {
        private readonly MPCommodityPostViewModel<TMStatus> _MPCommodityPostViewModel;
        private readonly MPCommodityPutViewModel<TMStatus> _MPCommodityPutViewModel;
        private readonly MPCommodityDeleteViewModel<TMStatus> _MPCommodityDeleteViewModel;
        private readonly MPCommodityGetsViewModel<TMStatus> _MPCommodityGetViewMode;
        public MPCommodityPageViewModel(
            MPCommodityPostViewModel<TMStatus> MPCommodityPostViewModel, 
            MPCommodityPutViewModel<TMStatus> MPCommodityPutViewModel,
            MPCommodityDeleteViewModel<TMStatus> MPCommodityDeleteViewModel, 
            MPCommodityGetsViewModel<TMStatus> MPCommodityGetViewModel)
                                            :base(MPCommodityPostViewModel, MPCommodityPutViewModel, MPCommodityDeleteViewModel, MPCommodityGetViewModel)
        {
            _MPCommodityPostViewModel = MPCommodityPostViewModel;
            _MPCommodityDeleteViewModel = MPCommodityDeleteViewModel;
            _MPCommodityGetViewMode = MPCommodityGetViewModel;
            _MPCommodityPutViewModel = MPCommodityPutViewModel;
        }
    }
}