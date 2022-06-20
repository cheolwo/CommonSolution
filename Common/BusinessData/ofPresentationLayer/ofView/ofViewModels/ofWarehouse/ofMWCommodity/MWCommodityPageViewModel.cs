using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessView.ofViewModels.ofGeneric;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofMWCommodity
{
    public class MWCommodityPageViewModel<TMStatus> : MStatusPageViewModel<TMStatus> where TMStatus : MWCommodityDTO, new()
    {
        private readonly MWCommodityPostViewModel<TMStatus> _MWCommodityPostViewModel;
        private readonly MWCommodityPutViewModel<TMStatus> _MWCommodityPutViewModel;
        private readonly MWCommodityDeleteViewModel<TMStatus> _MWCommodityDeleteViewModel;
        private readonly MWCommodityGetsViewModel<TMStatus> _MWCommodityGetViewMode;
        public MWCommodityPageViewModel(
            MWCommodityPostViewModel<TMStatus> MWCommodityPostViewModel, 
            MWCommodityPutViewModel<TMStatus> MWCommodityPutViewModel,
            MWCommodityDeleteViewModel<TMStatus> MWCommodityDeleteViewModel, 
            MWCommodityGetsViewModel<TMStatus> MWCommodityGetViewModel)
                                            :base(MWCommodityPostViewModel, MWCommodityPutViewModel, MWCommodityDeleteViewModel, MWCommodityGetViewModel)
        {
            _MWCommodityPostViewModel = MWCommodityPostViewModel;
            _MWCommodityDeleteViewModel = MWCommodityDeleteViewModel;
            _MWCommodityGetViewMode = MWCommodityGetViewModel;
            _MWCommodityPutViewModel = MWCommodityPutViewModel;
        }
    }
}