using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder;

namespace BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOCC
{
    public class GOCCPageViewModel<TCommodity> : CommodityPageViewModel<TCommodity> where TCommodity : GOCCDTO, new()
    {
        private readonly GOCCPostViewModel<TCommodity> _GOCCPostViewModel;
        private readonly GOCCPutViewModel<TCommodity> _GOCCPutViewModel;
        private readonly GOCCDeleteViewModel<TCommodity> _GOCCDeleteViewModel;
        private readonly GOCCGetsViewModel<TCommodity> _GOCCGetViewMode;
        public GOCCPageViewModel(
            GOCCPostViewModel<TCommodity> GOCCPostViewModel, 
            GOCCPutViewModel<TCommodity> GOCCPutViewModel,
            GOCCDeleteViewModel<TCommodity> GOCCDeleteViewModel, 
            GOCCGetsViewModel<TCommodity> GOCCGetViewModel)
                                            :base(GOCCPostViewModel, GOCCPutViewModel, GOCCDeleteViewModel, GOCCGetViewModel)
        {
            _GOCCPostViewModel = GOCCPostViewModel;
            _GOCCDeleteViewModel = GOCCDeleteViewModel;
            _GOCCGetViewMode = GOCCGetViewModel;
            _GOCCPutViewModel = GOCCPutViewModel;
        }
    }
}