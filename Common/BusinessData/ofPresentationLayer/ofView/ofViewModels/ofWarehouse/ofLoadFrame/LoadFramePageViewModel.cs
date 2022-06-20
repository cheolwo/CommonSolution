using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessView.ofViewModels.ofGeneric;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofLoadFrame
{
    public class LoadFramePageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : LoadFrameDTO, new()
    {
        private readonly LoadFramePostViewModel<TEntity> _LoadFramePostViewModel;
        private readonly LoadFramePutViewModel<TEntity> _LoadFramePutViewModel;
        private readonly LoadFrameDeleteViewModel<TEntity> _LoadFrameDeleteViewModel;
        private readonly LoadFrameGetsViewModel<TEntity> _LoadFrameGetViewMode;
        public LoadFramePageViewModel(
            LoadFramePostViewModel<TEntity> LoadFramePostViewModel, 
            LoadFramePutViewModel<TEntity> LoadFramePutViewModel,
            LoadFrameDeleteViewModel<TEntity> LoadFrameDeleteViewModel, 
            LoadFrameGetsViewModel<TEntity> LoadFrameGetViewModel)
                                            :base(LoadFramePostViewModel, LoadFramePutViewModel, LoadFrameDeleteViewModel, LoadFrameGetViewModel)
        {
            _LoadFramePostViewModel = LoadFramePostViewModel;
            _LoadFrameDeleteViewModel = LoadFrameDeleteViewModel;
            _LoadFrameGetViewMode = LoadFrameGetViewModel;
            _LoadFramePutViewModel = LoadFramePutViewModel;
        }
    }
}