using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;

namespace BusinessView.ofViewModels.ofWebApp.ofProduct.ofPCommodity
{
    public class PCommodityPageViewModel<TCommodity> : CommodityPageViewModel<TCommodity> where TCommodity : PCommodityDTO, new()
    {
        private readonly PCommodityPostViewModel<TCommodity> _PCommodityPostViewModel;
        private readonly PCommodityPutViewModel<TCommodity> _PCommodityPutViewModel;
        private readonly PCommodityDeleteViewModel<TCommodity> _PCommodityDeleteViewModel;
        private readonly PCommodityGetsViewModel<TCommodity> _PCommodityGetViewMode;
        public PCommodityPageViewModel(
            PCommodityPostViewModel<TCommodity> PCommodityPostViewModel, 
            PCommodityPutViewModel<TCommodity> PCommodityPutViewModel,
            PCommodityDeleteViewModel<TCommodity> PCommodityDeleteViewModel, 
            PCommodityGetsViewModel<TCommodity> PCommodityGetViewModel)
                                            :base(PCommodityPostViewModel, PCommodityPutViewModel, PCommodityDeleteViewModel, PCommodityGetViewModel)
        {
            _PCommodityPostViewModel = PCommodityPostViewModel;
            _PCommodityDeleteViewModel = PCommodityDeleteViewModel;
            _PCommodityGetViewMode = PCommodityGetViewModel;
            _PCommodityPutViewModel = PCommodityPutViewModel;
        }
    }
}