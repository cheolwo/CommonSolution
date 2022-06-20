using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessView.ofViewModels.ofGeneric;

namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofDotBarcode
{
    public class DotBarcodePageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : DotBarcodeDTO, new()
    {
        private readonly DotBarcodePostViewModel<TEntity> _DotBarcodePostViewModel;
        private readonly DotBarcodePutViewModel<TEntity> _DotBarcodePutViewModel;
        private readonly DotBarcodeDeleteViewModel<TEntity> _DotBarcodeDeleteViewModel;
        private readonly DotBarcodeGetsViewModel<TEntity> _DotBarcodeGetViewMode;
        public DotBarcodePageViewModel(
            DotBarcodePostViewModel<TEntity> DotBarcodePostViewModel, 
            DotBarcodePutViewModel<TEntity> DotBarcodePutViewModel,
            DotBarcodeDeleteViewModel<TEntity> DotBarcodeDeleteViewModel, 
            DotBarcodeGetsViewModel<TEntity> DotBarcodeGetViewModel)
                                            :base(DotBarcodePostViewModel, DotBarcodePutViewModel, DotBarcodeDeleteViewModel, DotBarcodeGetViewModel)
        {
            _DotBarcodePostViewModel = DotBarcodePostViewModel;
            _DotBarcodeDeleteViewModel = DotBarcodeDeleteViewModel;
            _DotBarcodeGetViewMode = DotBarcodeGetViewModel;
            _DotBarcodePutViewModel = DotBarcodePutViewModel;
        }
    }
}