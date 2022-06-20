using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofHR;

namespace BusinessView.ofViewModels.ofWebApp.ofHR.ofHRRole
{
    public class HRRolePageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : HRRoleDTO, new()
    {
        private readonly HRRolePostViewModel<TEntity> _HRRolePostViewModel;
        private readonly HRRolePutViewModel<TEntity> _HRRolePutViewModel;
        private readonly HRRoleDeleteViewModel<TEntity> _HRRoleDeleteViewModel;
        private readonly HRRoleGetsViewModel<TEntity> _HRRoleGetViewMode;
        public HRRolePageViewModel(
            HRRolePostViewModel<TEntity> HRRolePostViewModel, 
            HRRolePutViewModel<TEntity> HRRolePutViewModel,
            HRRoleDeleteViewModel<TEntity> HRRoleDeleteViewModel, 
            HRRoleGetsViewModel<TEntity> HRRoleGetViewModel)
                                            :base(HRRolePostViewModel, HRRolePutViewModel, HRRoleDeleteViewModel, HRRoleGetViewModel)
        {
            _HRRolePostViewModel = HRRolePostViewModel;
            _HRRoleDeleteViewModel = HRRoleDeleteViewModel;
            _HRRoleGetViewMode = HRRoleGetViewModel;
            _HRRolePutViewModel = HRRolePutViewModel;
        }
    }
}