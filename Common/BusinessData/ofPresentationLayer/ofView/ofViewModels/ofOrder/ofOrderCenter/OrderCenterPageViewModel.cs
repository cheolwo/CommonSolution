using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder;

namespace BusinessView.ofViewModels.ofWebApp.ofOrder.ofOrderCenter
{
    public class OrderCenterPageViewModel<TCenter> : CenterPageViewModel<TCenter> where TCenter : OrderCenterDTO, new()
    {
        private readonly OrderCenterPostViewModel<TCenter> _OrderCenterPostViewModel;
        private readonly OrderCenterPutViewModel<TCenter> _OrderCenterPutViewModel;
        private readonly OrderCenterDeleteViewModel<TCenter> _OrderCenterDeleteViewModel;
        private readonly OrderCenterGetsViewModel<TCenter> _OrderCenterGetViewMode;
        public OrderCenterPageViewModel(
            OrderCenterPostViewModel<TCenter> OrderCenterPostViewModel, 
            OrderCenterPutViewModel<TCenter> OrderCenterPutViewModel,
            OrderCenterDeleteViewModel<TCenter> OrderCenterDeleteViewModel, 
            OrderCenterGetsViewModel<TCenter> OrderCenterGetViewModel)
                                            :base(OrderCenterPostViewModel, OrderCenterPutViewModel, OrderCenterDeleteViewModel, OrderCenterGetViewModel)
        {
            _OrderCenterPostViewModel = OrderCenterPostViewModel;
            _OrderCenterDeleteViewModel = OrderCenterDeleteViewModel;
            _OrderCenterGetViewMode = OrderCenterGetViewModel;
            _OrderCenterPutViewModel = OrderCenterPutViewModel;
        }
    }
}