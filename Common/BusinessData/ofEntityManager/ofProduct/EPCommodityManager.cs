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
    public interface IEPCommodityManager : IEStatusManager<EPCommodity>
    {
        
    }

    public class EPCommodityManager : EStatusManager<EPCommodity>, IEmployerEPCommodityManager, IEmployeeEPCommodityManager, IPlatformEPCommodityManager, IEPCommodityManager
    {
        private readonly IEPCommodityRepository _EPCommodityRepository;
        public EPCommodityManager(IEPCommodityRepository EPCommodityRepository,
                               IEPCommodityIdFactory EPCommodityIdFactory,
                               IEPCommodityFileFactory EPCommodityFileFactory,
                               IEPCommodityBlobStorage blobStorage,
                            DicConvertFactory<EPCommodity> dicConvertFactory)
            : base(EPCommodityRepository, EPCommodityIdFactory, EPCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _EPCommodityRepository = EPCommodityRepository;
        }
    }
}