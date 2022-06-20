using BusinessView.ofViewModels.ofGeneric;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;

namespace BusinessView.ofViewModels.ofWebApp.ofProduct.ofProductLand
{
    public class ProductLandPageViewModel<TEntity> : EntityPageViewModel<TEntity> where TEntity : ProductLandDTO, new()
    {
        private readonly ProductLandPostViewModel<TEntity> _ProductLandPostViewModel;
        private readonly ProductLandPutViewModel<TEntity> _ProductLandPutViewModel;
        private readonly ProductLandDeleteViewModel<TEntity> _ProductLandDeleteViewModel;
        private readonly ProductLandGetsViewModel<TEntity> _ProductLandGetViewMode;
        public ProductLandPageViewModel(
            ProductLandPostViewModel<TEntity> ProductLandPostViewModel, 
            ProductLandPutViewModel<TEntity> ProductLandPutViewModel,
            ProductLandDeleteViewModel<TEntity> ProductLandDeleteViewModel, 
            ProductLandGetsViewModel<TEntity> ProductLandGetViewModel)
                                            :base(ProductLandPostViewModel, ProductLandPutViewModel, ProductLandDeleteViewModel, ProductLandGetViewModel)
        {
            _ProductLandPostViewModel = ProductLandPostViewModel;
            _ProductLandDeleteViewModel = ProductLandDeleteViewModel;
            _ProductLandGetViewMode = ProductLandGetViewModel;
            _ProductLandPutViewModel = ProductLandPutViewModel;
        }
    }
}