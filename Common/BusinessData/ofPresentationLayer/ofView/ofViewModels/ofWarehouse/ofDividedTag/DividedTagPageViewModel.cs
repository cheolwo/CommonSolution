using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofDividedTag
{
    public class DividedTagPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : DividedTagDTO, new()
    {
        private readonly DividedTagPostViewModel<TEntity> _DividedTagPostViewModel;
        private readonly DividedTagPutViewModel<TEntity> _DividedTagPutViewModel;
        private readonly DividedTagDeleteViewModel<TEntity> _DividedTagDeleteViewModel;
        private readonly DividedTagGetsViewModel<TEntity> _DividedTagGetViewMode;
        public DividedTagPageViewModel(
            DividedTagPostViewModel<TEntity> DividedTagPostViewModel, 
            DividedTagPutViewModel<TEntity> DividedTagPutViewModel,
            DividedTagDeleteViewModel<TEntity> DividedTagDeleteViewModel, 
            DividedTagGetsViewModel<TEntity> DividedTagGetViewModel)
                                            :base(DividedTagPostViewModel, DividedTagPutViewModel, DividedTagDeleteViewModel, DividedTagGetViewModel)
        {
            _DividedTagPostViewModel = DividedTagPostViewModel;
            _DividedTagDeleteViewModel = DividedTagDeleteViewModel;
            _DividedTagGetViewMode = DividedTagGetViewModel;
            _DividedTagPutViewModel = DividedTagPutViewModel;
        }
    }
}