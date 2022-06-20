using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofJournal;

namespace BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournalCenter
{
    public class JournalCenterPageViewModel<TCenter> : CenterPageViewModel<TCenter> where TCenter : JournalCenterDTO, new()
    {
        private readonly JournalCenterPostViewModel<TCenter> _JournalCenterPostViewModel;
        private readonly JournalCenterPutViewModel<TCenter> _JournalCenterPutViewModel;
        private readonly JournalCenterDeleteViewModel<TCenter> _JournalCenterDeleteViewModel;
        private readonly JournalCenterGetsViewModel<TCenter> _JournalCenterGetViewMode;
        public JournalCenterPageViewModel(
            JournalCenterPostViewModel<TCenter> JournalCenterPostViewModel, 
            JournalCenterPutViewModel<TCenter> JournalCenterPutViewModel,
            JournalCenterDeleteViewModel<TCenter> JournalCenterDeleteViewModel, 
            JournalCenterGetsViewModel<TCenter> JournalCenterGetViewModel)
                                            :base(JournalCenterPostViewModel, JournalCenterPutViewModel, JournalCenterDeleteViewModel, JournalCenterGetViewModel)
        {
            _JournalCenterPostViewModel = JournalCenterPostViewModel;
            _JournalCenterDeleteViewModel = JournalCenterDeleteViewModel;
            _JournalCenterGetViewMode = JournalCenterGetViewModel;
            _JournalCenterPutViewModel = JournalCenterPutViewModel;
        }
    }
}