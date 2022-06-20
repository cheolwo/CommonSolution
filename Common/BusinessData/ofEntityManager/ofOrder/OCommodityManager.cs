using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofDataAccessLayer.ofOrder.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofOrder.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofOrder.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofOrder.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofOrder.ofInterface.ofPlatform;
using BusinessLogic.ofEntityManager.ofOrder.ofFileFactory;
using BusinessLogic.ofEntityManager.ofOrder.ofIdFactory;

namespace BusinessLogic.ofEntityManager.ofOrder
{
    public interface IOCommodityManager : ICommodityManager<OCommodity>
    {
    }
    public class OCommodityManager : CommodityManager<OCommodity>, IEmployerOCommodityManager, IEmployeeOCommodityManager, IPlatformOCommodityManager, IOCommodityManager
    {
        public readonly IOCommodityRepository _OCommodityRepository;
        public OCommodityManager(IOCommodityRepository OCommodityRepository,
                               IOCommodityIdFactory OCommodityIdFactory,
                               IOCommodityFileFactory OCommodityFileFactory,
                               IOCommodityBlobStorage blobStorage,
                            DicConvertFactory<OCommodity> dicConvertFactory)
            : base(OCommodityRepository, OCommodityIdFactory, OCommodityFileFactory, blobStorage, dicConvertFactory)
        {
        }
    }
}
