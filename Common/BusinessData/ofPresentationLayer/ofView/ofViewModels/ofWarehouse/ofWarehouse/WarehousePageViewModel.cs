using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessView.ofViewModels.ofGeneric;
namespace BusinessView.ofViewModels.ofWebApp.ofWarehouse.ofWarehouse
{
    public class WarehousePageViewModel<TCenter> : CenterPageViewModel<TCenter> where TCenter : WarehouseDTO, new()
    {
        private readonly WarehousePostViewModel<TCenter> _WarehousePostViewModel;
        private readonly WarehousePutViewModel<TCenter> _WarehousePutViewModel;
        private readonly WarehouseDeleteViewModel<TCenter> _WarehouseDeleteViewModel;
        private readonly WarehouseGetsViewModel<TCenter> _WarehouseGetViewMode;
        public WarehousePageViewModel(
            WarehousePostViewModel<TCenter> WarehousePostViewModel, 
            WarehousePutViewModel<TCenter> WarehousePutViewModel,
            WarehouseDeleteViewModel<TCenter> WarehouseDeleteViewModel, 
            WarehouseGetsViewModel<TCenter> WarehouseGetViewModel)
                                            :base(WarehousePostViewModel, WarehousePutViewModel, WarehouseDeleteViewModel, WarehouseGetViewModel)
        {
            _WarehousePostViewModel = WarehousePostViewModel;
            _WarehouseDeleteViewModel = WarehouseDeleteViewModel;
            _WarehouseGetViewMode = WarehouseGetViewModel;
            _WarehousePutViewModel = WarehousePutViewModel;
        }
    }
}