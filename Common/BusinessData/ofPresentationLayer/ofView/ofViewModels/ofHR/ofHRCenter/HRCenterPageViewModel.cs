using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofHR;

namespace BusinessView.ofViewModels.ofWebApp.ofHR.ofHRCenter
{
    public class HRCenterPageViewModel<TCenter> : CenterPageViewModel<TCenter> where TCenter : HRCenterDTO, new()
    {
        private readonly HRCenterPostViewModel<TCenter> _HRCenterPostViewModel;
        private readonly HRCenterPutViewModel<TCenter> _HRCenterPutViewModel;
        private readonly HRCenterDeleteViewModel<TCenter> _HRCenterDeleteViewModel;
        private readonly HRCenterGetsViewModel<TCenter> _HRCenterGetViewMode;
        public HRCenterPageViewModel(
            HRCenterPostViewModel<TCenter> HRCenterPostViewModel, 
            HRCenterPutViewModel<TCenter> HRCenterPutViewModel,
            HRCenterDeleteViewModel<TCenter> HRCenterDeleteViewModel, 
            HRCenterGetsViewModel<TCenter> HRCenterGetViewModel)
                                            :base(HRCenterPostViewModel, HRCenterPutViewModel, HRCenterDeleteViewModel, HRCenterGetViewModel)
        {
            _HRCenterPostViewModel = HRCenterPostViewModel;
            _HRCenterDeleteViewModel = HRCenterDeleteViewModel;
            _HRCenterGetViewMode = HRCenterGetViewModel;
            _HRCenterPutViewModel = HRCenterPutViewModel;
        }
    }
}