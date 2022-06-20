using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder;
using BusinessView.ofViewModels.ofGeneric;
namespace BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofEGOC
{
    public class EGOCPageViewModel<TEStatus> : EStatusPageViewModel<TEStatus> where TEStatus : EGOCDTO, new()
    {
        private readonly EGOCPostViewModel<TEStatus> _EGOCPostViewModel;
        private readonly EGOCPutViewModel<TEStatus> _EGOCPutViewModel;
        private readonly EGOCDeleteViewModel<TEStatus> _EGOCDeleteViewModel;
        private readonly EGOCGetsViewModel<TEStatus> _EGOCGetViewMode;
        public EGOCPageViewModel(
            EGOCPostViewModel<TEStatus> EGOCPostViewModel, 
            EGOCPutViewModel<TEStatus> EGOCPutViewModel,
            EGOCDeleteViewModel<TEStatus> EGOCDeleteViewModel, 
            EGOCGetsViewModel<TEStatus> EGOCGetViewModel)
                                            :base(EGOCPostViewModel, EGOCPutViewModel, EGOCDeleteViewModel, EGOCGetViewModel)
        {
            _EGOCPostViewModel = EGOCPostViewModel;
            _EGOCDeleteViewModel = EGOCDeleteViewModel;
            _EGOCGetViewMode = EGOCGetViewModel;
            _EGOCPutViewModel = EGOCPutViewModel;
        }
    }
}