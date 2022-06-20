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
    public class MWCommodityManager : StatusManager<MWCommodity>, IEmployerMWCommodityManager, IEmployeeMWCommodityManager, IPlatformMWCommodityManager, IMWCommodityManager
    {
        public MWCommodityManager(IMWCommodityRepository StatusDataRepository,
            IMWCommodityIdFactory mWCommodityIdFactory,
                               IMWCommodityFileFactory StatusFileFactory,
                               IMWCommodityBlobStorage blobStorage,
                            DicConvertFactory<MWCommodity> dicConvertFactory)
            : base(StatusDataRepository, mWCommodityIdFactory, StatusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}