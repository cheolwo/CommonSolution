using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessView.ofViewModels.ofGeneric;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWorkingDesk
{
    public class WorkingDeskPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : WorkingDeskDTO, new()
    {
        private readonly WorkingDeskPostViewModel<TEntity> _WorkingDeskPostViewModel;
        private readonly WorkingDeskPutViewModel<TEntity> _WorkingDeskPutViewModel;
        private readonly WorkingDeskDeleteViewModel<TEntity> _WorkingDeskDeleteViewModel;
        private readonly WorkingDeskGetsViewModel<TEntity> _WorkingDeskGetViewMode;
        public WorkingDeskPageViewModel(
            WorkingDeskPostViewModel<TEntity> WorkingDeskPostViewModel, 
            WorkingDeskPutViewModel<TEntity> WorkingDeskPutViewModel,
            WorkingDeskDeleteViewModel<TEntity> WorkingDeskDeleteViewModel, 
            WorkingDeskGetsViewModel<TEntity> WorkingDeskGetViewModel)
                                            :base(WorkingDeskPostViewModel, WorkingDeskPutViewModel, WorkingDeskDeleteViewModel, WorkingDeskGetViewModel)
        {
            _WorkingDeskPostViewModel = WorkingDeskPostViewModel;
            _WorkingDeskDeleteViewModel = WorkingDeskDeleteViewModel;
            _WorkingDeskGetViewMode = WorkingDeskGetViewModel;
            _WorkingDeskPutViewModel = WorkingDeskPutViewModel;
        }
    }
}