using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder;

namespace BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofMGOC
{
    public class MGOCPageViewModel<TMStatus> : MStatusPageViewModel<TMStatus> where TMStatus : MGOCDTO, new()
    {
        private readonly MGOCPostViewModel<TMStatus> _MGOCPostViewModel;
        private readonly MGOCPutViewModel<TMStatus> _MGOCPutViewModel;
        private readonly MGOCDeleteViewModel<TMStatus> _MGOCDeleteViewModel;
        private readonly MGOCGetsViewModel<TMStatus> _MGOCGetViewMode;
        public MGOCPageViewModel(
            MGOCPostViewModel<TMStatus> MGOCPostViewModel, 
            MGOCPutViewModel<TMStatus> MGOCPutViewModel,
            MGOCDeleteViewModel<TMStatus> MGOCDeleteViewModel, 
            MGOCGetsViewModel<TMStatus> MGOCGetViewModel)
                                            :base(MGOCPostViewModel, MGOCPutViewModel, MGOCDeleteViewModel, MGOCGetViewModel)
        {
            _MGOCPostViewModel = MGOCPostViewModel;
            _MGOCDeleteViewModel = MGOCDeleteViewModel;
            _MGOCGetViewMode = MGOCGetViewModel;
            _MGOCPutViewModel = MGOCPutViewModel;
        }
    }
}