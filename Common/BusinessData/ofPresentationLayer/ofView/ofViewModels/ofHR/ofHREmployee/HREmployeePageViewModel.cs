using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofHR;

namespace BusinessView.ofViewModels.ofWebApp.ofHR.ofHREmployee
{
    public class HREmployeePageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : HREmployeeDTO, new()
    {
        private readonly HREmployeePostViewModel<TEntity> _HREmployeePostViewModel;
        private readonly HREmployeePutViewModel<TEntity> _HREmployeePutViewModel;
        private readonly HREmployeeDeleteViewModel<TEntity> _HREmployeeDeleteViewModel;
        private readonly HREmployeeGetsViewModel<TEntity> _HREmployeeGetViewMode;
        public HREmployeePageViewModel(
            HREmployeePostViewModel<TEntity> HREmployeePostViewModel, 
            HREmployeePutViewModel<TEntity> HREmployeePutViewModel,
            HREmployeeDeleteViewModel<TEntity> HREmployeeDeleteViewModel, 
            HREmployeeGetsViewModel<TEntity> HREmployeeGetViewModel)
                                            :base(HREmployeePostViewModel, HREmployeePutViewModel, HREmployeeDeleteViewModel, HREmployeeGetViewModel)
        {
            _HREmployeePostViewModel = HREmployeePostViewModel;
            _HREmployeeDeleteViewModel = HREmployeeDeleteViewModel;
            _HREmployeeGetViewMode = HREmployeeGetViewModel;
            _HREmployeePutViewModel = HREmployeePutViewModel;
        }
    }
}