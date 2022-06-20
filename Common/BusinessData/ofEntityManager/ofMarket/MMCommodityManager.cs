using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofDataAccessLayer.ofMarket.ofRepository;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofMarket.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofMarket.ofIdFactory;
using BusinessLogic.ofEntityManager.ofMarket.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofMarket.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofMarket.ofInterface.ofPlatform;

namespace BusinessLogic.ofEntityManager.ofMarket
{
    public interface IMMCommodityManager : IMStatusManager<MMCommodity>
    {

    }
    [DataManager(typeof(MMCommodity))]
    public class MMCommodityManager : MStatusManager<MMCommodity>, IEmployerMMCommodityManager, IEmployeeMMCommodityManager, IPaltformMMCommodityManager, IMMCommodityManager
    {
        public MMCommodityManager(IMMCommodityRepository statusDataRepository,
            IMMCommodityIdFactory mMCommodityIdFactory,
                               IMMCommodityFileFactory statusFileFactory,
                               IMMCommodityBlobStorage blobStorage,
                            DicConvertFactory<MMCommodity> dicConvertFactory)
            : base(statusDataRepository, mMCommodityIdFactory, statusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}