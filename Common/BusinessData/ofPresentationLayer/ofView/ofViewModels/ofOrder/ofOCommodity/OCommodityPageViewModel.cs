using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder;

namespace BusinessView.ofViewModels.ofWebApp.ofOrder.ofOCommodity
{
    public class OCommodityPageViewModel<TCommodity> : CommodityPageViewModel<TCommodity> where TCommodity : OCommodityDTO, new()
    {
        private readonly OCommodityPostViewModel<TCommodity> _OCommodityPostViewModel;
        private readonly OCommodityPutViewModel<TCommodity> _OCommodityPutViewModel;
        private readonly OCommodityDeleteViewModel<TCommodity> _OCommodityDeleteViewModel;
        private readonly OCommodityGetsViewModel<TCommodity> _OCommodityGetViewMode;
        public OCommodityPageViewModel(
            OCommodityPostViewModel<TCommodity> OCommodityPostViewModel, 
            OCommodityPutViewModel<TCommodity> OCommodityPutViewModel,
            OCommodityDeleteViewModel<TCommodity> OCommodityDeleteViewModel, 
            OCommodityGetsViewModel<TCommodity> OCommodityGetViewModel)
                                            :base(OCommodityPostViewModel, OCommodityPutViewModel, OCommodityDeleteViewModel, OCommodityGetViewModel)
        {
            _OCommodityPostViewModel = OCommodityPostViewModel;
            _OCommodityDeleteViewModel = OCommodityDeleteViewModel;
            _OCommodityGetViewMode = OCommodityGetViewModel;
            _OCommodityPutViewModel = OCommodityPutViewModel;
        }
    }
}