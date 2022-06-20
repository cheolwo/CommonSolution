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
    public class EWCommodityManager : StatusManager<EWCommodity>, IEmployerEWCommodityManager, IEmployeeEWCommodityManager, IPlatformEWCommodityManager, IEWCommodityManager
    {
        public EWCommodityManager(IEWCommodityRepository StatusDataRepository,
            IEWCommodityIdFactory eWCommodityIdFactory,
                               IEWCommodityFileFactory StatusFileFactory,
                               IEWCommodityBlobStorage blobStorage,
                            DicConvertFactory<EWCommodity> dicConvertFactory)
            : base(StatusDataRepository, eWCommodityIdFactory, StatusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}