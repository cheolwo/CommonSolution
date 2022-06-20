using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofHR;

namespace BusinessView.ofViewModels.ofWebApp.ofHR.ofHRBusinessPart
{
    public class HRBusinessPartPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : HRBusinessPartDTO, new()
    {
        private readonly HRBusinessPartPostViewModel<TEntity> _HRBusinessPartPostViewModel;
        private readonly HRBusinessPartPutViewModel<TEntity> _HRBusinessPartPutViewModel;
        private readonly HRBusinessPartDeleteViewModel<TEntity> _HRBusinessPartDeleteViewModel;
        private readonly HRBusinessPartGetsViewModel<TEntity> _HRBusinessPartGetViewMode;
        public HRBusinessPartPageViewModel(
            HRBusinessPartPostViewModel<TEntity> HRBusinessPartPostViewModel, 
            HRBusinessPartPutViewModel<TEntity> HRBusinessPartPutViewModel,
            HRBusinessPartDeleteViewModel<TEntity> HRBusinessPartDeleteViewModel, 
            HRBusinessPartGetsViewModel<TEntity> HRBusinessPartGetViewModel)
                                            :base(HRBusinessPartPostViewModel, HRBusinessPartPutViewModel, HRBusinessPartDeleteViewModel, HRBusinessPartGetViewModel)
        {
            _HRBusinessPartPostViewModel = HRBusinessPartPostViewModel;
            _HRBusinessPartDeleteViewModel = HRBusinessPartDeleteViewModel;
            _HRBusinessPartGetViewMode = HRBusinessPartGetViewModel;
            _HRBusinessPartPutViewModel = HRBusinessPartPutViewModel;
        }
    }
}