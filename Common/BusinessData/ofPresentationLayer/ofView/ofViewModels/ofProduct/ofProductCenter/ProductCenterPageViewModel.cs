using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;

namespace BusinessView.ofViewModels.ofWebApp.ofProduct.ofProductCenter
{
    public class ProductCenterPageViewModel<TCenter> : CenterPageViewModel<TCenter> where TCenter : ProductCenterDTO, new()
    {
        private readonly ProductCenterPostViewModel<TCenter> _ProductCenterPostViewModel;
        private readonly ProductCenterPutViewModel<TCenter> _ProductCenterPutViewModel;
        private readonly ProductCenterDeleteViewModel<TCenter> _ProductCenterDeleteViewModel;
        private readonly ProductCenterGetsViewModel<TCenter> _ProductCenterGetViewMode;
        public ProductCenterPageViewModel(
            ProductCenterPostViewModel<TCenter> ProductCenterPostViewModel, 
            ProductCenterPutViewModel<TCenter> ProductCenterPutViewModel,
            ProductCenterDeleteViewModel<TCenter> ProductCenterDeleteViewModel, 
            ProductCenterGetsViewModel<TCenter> ProductCenterGetViewModel)
                                            :base(ProductCenterPostViewModel, ProductCenterPutViewModel, ProductCenterDeleteViewModel, ProductCenterGetViewModel)
        {
            _ProductCenterPostViewModel = ProductCenterPostViewModel;
            _ProductCenterDeleteViewModel = ProductCenterDeleteViewModel;
            _ProductCenterGetViewMode = ProductCenterGetViewModel;
            _ProductCenterPutViewModel = ProductCenterPutViewModel;
        }
    }
}