using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofJournal;

namespace BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournal
{
    public class JournalPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : JournalDTO, new()
    {
        private readonly JournalPostViewModel<TEntity> _JournalPostViewModel;
        private readonly JournalPutViewModel<TEntity> _JournalPutViewModel;
        private readonly JournalDeleteViewModel<TEntity> _JournalDeleteViewModel;
        private readonly JournalGetsViewModel<TEntity> _JournalGetViewMode;
        public JournalPageViewModel(
            JournalPostViewModel<TEntity> JournalPostViewModel, 
            JournalPutViewModel<TEntity> JournalPutViewModel,
            JournalDeleteViewModel<TEntity> JournalDeleteViewModel, 
            JournalGetsViewModel<TEntity> JournalGetViewModel)
                                            :base(JournalPostViewModel, JournalPutViewModel, JournalDeleteViewModel, JournalGetViewModel)
        {
            _JournalPostViewModel = JournalPostViewModel;
            _JournalDeleteViewModel = JournalDeleteViewModel;
            _JournalGetViewMode = JournalGetViewModel;
            _JournalPutViewModel = JournalPutViewModel;
        }
    }
}