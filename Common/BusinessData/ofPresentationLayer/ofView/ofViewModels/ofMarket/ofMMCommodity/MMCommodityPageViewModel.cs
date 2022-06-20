using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket;

namespace BusinessView.ofViewModels.ofWebApp.ofMarket.ofMMCommodity
{
    public class MMCommodityPageViewModel<TMStatus> : MStatusPageViewModel<TMStatus> where TMStatus : MMCommodityDTO, new()
    {
        private readonly MMCommodityPostViewModel<TMStatus> _MMCommodityPostViewModel;
        private readonly MMCommodityPutViewModel<TMStatus> _MMCommodityPutViewModel;
        private readonly MMCommodityDeleteViewModel<TMStatus> _MMCommodityDeleteViewModel;
        private readonly MMCommodityGetsViewModel<TMStatus> _MMCommodityGetViewMode;
        public MMCommodityPageViewModel(
            MMCommodityPostViewModel<TMStatus> MMCommodityPostViewModel, 
            MMCommodityPutViewModel<TMStatus> MMCommodityPutViewModel,
            MMCommodityDeleteViewModel<TMStatus> MMCommodityDeleteViewModel, 
            MMCommodityGetsViewModel<TMStatus> MMCommodityGetViewModel)
                                            :base(MMCommodityPostViewModel, MMCommodityPutViewModel, MMCommodityDeleteViewModel, MMCommodityGetViewModel)
        {
            _MMCommodityPostViewModel = MMCommodityPostViewModel;
            _MMCommodityDeleteViewModel = MMCommodityDeleteViewModel;
            _MMCommodityGetViewMode = MMCommodityGetViewModel;
            _MMCommodityPutViewModel = MMCommodityPutViewModel;
        }
    }
}