using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder;

namespace BusinessView.ofViewModels.ofWebApp.ofGroupOrder.ofSGOC
{
    public class SGOCPageViewModel<TSStatus> : SStatusPageViewModel<TSStatus> where TSStatus : SGOCDTO, new()
    {
        private readonly SGOCPostViewModel<TSStatus> _SGOCPostViewModel;
        private readonly SGOCPutViewModel<TSStatus> _SGOCPutViewModel;
        private readonly SGOCDeleteViewModel<TSStatus> _SGOCDeleteViewModel;
        private readonly SGOCGetsViewModel<TSStatus> _SGOCGetViewMode;
        public SGOCPageViewModel(
            SGOCPostViewModel<TSStatus> SGOCPostViewModel, 
            SGOCPutViewModel<TSStatus> SGOCPutViewModel,
            SGOCDeleteViewModel<TSStatus> SGOCDeleteViewModel, 
            SGOCGetsViewModel<TSStatus> SGOCGetViewModel)
                                            :base(SGOCPostViewModel, SGOCPutViewModel, SGOCDeleteViewModel, SGOCGetViewModel)
        {
            _SGOCPostViewModel = SGOCPostViewModel;
            _SGOCDeleteViewModel = SGOCDeleteViewModel;
            _SGOCGetViewMode = SGOCGetViewModel;
            _SGOCPutViewModel = SGOCPutViewModel;
        }
    }
}