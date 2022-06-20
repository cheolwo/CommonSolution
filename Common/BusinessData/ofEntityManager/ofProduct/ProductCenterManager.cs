using BusinessData.ofProduct.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofProduct.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofProduct.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofProduct.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofProduct.ofInterface.ofPlatform;
using BusinessLogic.ofEntityManager.ofProduct.ofFileFactory;
using BusinessLogic.ofEntityManager.ofProduct.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;

namespace BusinessLogic.ofEntityManager.ofProduct
{
    public interface IProductCenterManager : ICenterManager<ProductCenter>
    {

    }
    public class ProductCenterManager : CenterManager<ProductCenter>, IEmployerProductCenterManager, IEmployeeProductCenterManager, IPlatformProductCenterManager, IProductCenterManager
    {
        private readonly IProductCenterRepository _ProductCenterRepository;
        public ProductCenterManager(IProductCenterRepository ProductCenterRepository,
                               IProductCenterIdFactory ProductCenterIdFactory,
                               IProductCenterFileFactory ProductCenterFileFactory,
                               IProductCenterBlobStorage blobStorage,
                               CenterPasswordHasher<ProductCenter> centerPasswordHasher,
                            DicConvertFactory<ProductCenter> dicConvertFactory)
            : base(ProductCenterRepository, ProductCenterIdFactory, ProductCenterFileFactory, blobStorage, dicConvertFactory, centerPasswordHasher)
        {
            _ProductCenterRepository = ProductCenterRepository;
        }
        
    }
}