using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade;

namespace BusinessView.ofViewModels.ofWebApp.ofTrade.ofMTCommodity
{
    public class MTCommodityPageViewModel<TMStatus> : MStatusPageViewModel<TMStatus> where TMStatus : MTCommodityDTO, new()
    {
        private readonly MTCommodityPostViewModel<TMStatus> _MTCommodityPostViewModel;
        private readonly MTCommodityPutViewModel<TMStatus> _MTCommodityPutViewModel;
        private readonly MTCommodityDeleteViewModel<TMStatus> _MTCommodityDeleteViewModel;
        private readonly MTCommodityGetsViewModel<TMStatus> _MTCommodityGetViewMode;
        public MTCommodityPageViewModel(
            MTCommodityPostViewModel<TMStatus> MTCommodityPostViewModel, 
            MTCommodityPutViewModel<TMStatus> MTCommodityPutViewModel,
            MTCommodityDeleteViewModel<TMStatus> MTCommodityDeleteViewModel, 
            MTCommodityGetsViewModel<TMStatus> MTCommodityGetViewModel)
                                            :base(MTCommodityPostViewModel, MTCommodityPutViewModel, MTCommodityDeleteViewModel, MTCommodityGetViewModel)
        {
            _MTCommodityPostViewModel = MTCommodityPostViewModel;
            _MTCommodityDeleteViewModel = MTCommodityDeleteViewModel;
            _MTCommodityGetViewMode = MTCommodityGetViewModel;
            _MTCommodityPutViewModel = MTCommodityPutViewModel;
        }
    }
}