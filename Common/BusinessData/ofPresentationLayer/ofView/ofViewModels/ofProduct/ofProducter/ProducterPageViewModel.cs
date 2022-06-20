using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;

namespace BusinessView.ofViewModels.ofWebApp.ofProduct.ofProducter
{
    public class ProducterPageViewModel<TCenter> : CenterPageViewModel<TCenter> where TCenter : ProducterDTO, new()
    {
        private readonly ProducterPostViewModel<TCenter> _ProducterPostViewModel;
        private readonly ProducterPutViewModel<TCenter> _ProducterPutViewModel;
        private readonly ProducterDeleteViewModel<TCenter> _ProducterDeleteViewModel;
        private readonly ProducterGetsViewModel<TCenter> _ProducterGetViewMode;
        public ProducterPageViewModel(
            ProducterPostViewModel<TCenter> ProducterPostViewModel, 
            ProducterPutViewModel<TCenter> ProducterPutViewModel,
            ProducterDeleteViewModel<TCenter> ProducterDeleteViewModel, 
            ProducterGetsViewModel<TCenter> ProducterGetViewModel)
                                            :base(ProducterPostViewModel, ProducterPutViewModel, ProducterDeleteViewModel, ProducterGetViewModel)
        {
            _ProducterPostViewModel = ProducterPostViewModel;
            _ProducterDeleteViewModel = ProducterDeleteViewModel;
            _ProducterGetViewMode = ProducterGetViewModel;
            _ProducterPutViewModel = ProducterPutViewModel;
        }
    }
}