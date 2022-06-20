using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofJournal;

namespace BusinessView.ofViewModels.ofWebApp.ofJournal.ofJCommodity
{
    public class JCommodityPageViewModel<TCommodity> : CommodityPageViewModel<TCommodity> where TCommodity : JCommodityDTO, new()
    {
        private readonly JCommodityPostViewModel<TCommodity> _JCommodityPostViewModel;
        private readonly JCommodityPutViewModel<TCommodity> _JCommodityPutViewModel;
        private readonly JCommodityDeleteViewModel<TCommodity> _JCommodityDeleteViewModel;
        private readonly JCommodityGetsViewModel<TCommodity> _JCommodityGetViewMode;
        public JCommodityPageViewModel(
            JCommodityPostViewModel<TCommodity> JCommodityPostViewModel, 
            JCommodityPutViewModel<TCommodity> JCommodityPutViewModel,
            JCommodityDeleteViewModel<TCommodity> JCommodityDeleteViewModel, 
            JCommodityGetsViewModel<TCommodity> JCommodityGetViewModel)
                                            :base(JCommodityPostViewModel, JCommodityPutViewModel, JCommodityDeleteViewModel, JCommodityGetViewModel)
        {
            _JCommodityPostViewModel = JCommodityPostViewModel;
            _JCommodityDeleteViewModel = JCommodityDeleteViewModel;
            _JCommodityGetViewMode = JCommodityGetViewModel;
            _JCommodityPutViewModel = JCommodityPutViewModel;
        }
    }
}