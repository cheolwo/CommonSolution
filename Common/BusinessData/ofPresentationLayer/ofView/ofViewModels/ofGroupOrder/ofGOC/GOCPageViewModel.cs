using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder;

namespace BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofGOC
{
    public class GOCPageViewModel<TCenter> : CenterPageViewModel<TCenter> where TCenter : GOCDTO, new()
    {
        private readonly GOCPostViewModel<TCenter> _GOCPostViewModel;
        private readonly GOCPutViewModel<TCenter> _GOCPutViewModel;
        private readonly GOCDeleteViewModel<TCenter> _GOCDeleteViewModel;
        private readonly GOCGetsViewModel<TCenter> _GOCGetViewMode;
        public GOCPageViewModel(
            GOCPostViewModel<TCenter> GOCPostViewModel, 
            GOCPutViewModel<TCenter> GOCPutViewModel,
            GOCDeleteViewModel<TCenter> GOCDeleteViewModel, 
            GOCGetsViewModel<TCenter> GOCGetViewModel)
                                            :base(GOCPostViewModel, GOCPutViewModel, GOCDeleteViewModel, GOCGetViewModel)
        {
            _GOCPostViewModel = GOCPostViewModel;
            _GOCDeleteViewModel = GOCDeleteViewModel;
            _GOCGetViewMode = GOCGetViewModel;
            _GOCPutViewModel = GOCPutViewModel;
        }
    }
}