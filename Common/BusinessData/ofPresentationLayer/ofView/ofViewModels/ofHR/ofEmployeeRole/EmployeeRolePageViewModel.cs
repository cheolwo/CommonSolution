using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofHR;

namespace BusinessView.ofViewModels.ofWebApp.ofHR.ofEmployeeRole
{
    public class EmployeeRolePageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : EmployeeRoleDTO, new()
    {
        private readonly EmployeeRolePostViewModel<TEntity> _EmployeeRolePostViewModel;
        private readonly EmployeeRolePutViewModel<TEntity> _EmployeeRolePutViewModel;
        private readonly EmployeeRoleDeleteViewModel<TEntity> _EmployeeRoleDeleteViewModel;
        private readonly EmployeeRoleGetsViewModel<TEntity> _EmployeeRoleGetViewMode;
        public EmployeeRolePageViewModel(
            EmployeeRolePostViewModel<TEntity> EmployeeRolePostViewModel, 
            EmployeeRolePutViewModel<TEntity> EmployeeRolePutViewModel,
            EmployeeRoleDeleteViewModel<TEntity> EmployeeRoleDeleteViewModel, 
            EmployeeRoleGetsViewModel<TEntity> EmployeeRoleGetViewModel)
                                            :base(EmployeeRolePostViewModel, EmployeeRolePutViewModel, EmployeeRoleDeleteViewModel, EmployeeRoleGetViewModel)
        {
            _EmployeeRolePostViewModel = EmployeeRolePostViewModel;
            _EmployeeRoleDeleteViewModel = EmployeeRoleDeleteViewModel;
            _EmployeeRoleGetViewMode = EmployeeRoleGetViewModel;
            _EmployeeRolePutViewModel = EmployeeRolePutViewModel;
        }
    }
}