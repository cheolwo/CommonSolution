using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofInterface;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofEntityManager.ofWarehouse.ofIdFactory;
using BusinessLogic.ofEntityManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofWarehouse.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofWarehouse.ofInterface.ofPlatform;

namespace BusinessLogic.ofEntityManager.ofWarehouse
{
    public class SWCommodityManager : StatusManager<SWCommodity>, IEmployerSWCommodityManager, IEmployeeSWCommodityManager, IPlatformSWCommodityManager, ISWCommodityManager
    {
        public SWCommodityManager(ISWCommodityRepository StatusDataRepository,
            ISWCommodityIdFactory sWCommodityIdFactory,
                               ISWCommodityFileFactory StatusFileFactory,
                               ISWCommodityBlobStorage blobStorage,
                            DicConvertFactory<SWCommodity> dicConvertFactory)
            : base(StatusDataRepository, sWCommodityIdFactory, StatusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}