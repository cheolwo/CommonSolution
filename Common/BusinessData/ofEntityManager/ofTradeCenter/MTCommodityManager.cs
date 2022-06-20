using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using BusinessData.ofDataAccessLayer.ofTrade.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofTrade.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofTrade.ofFileFactory;
using BusinessLogic.ofEntityManager.ofTrade.ofIdFactory;
using BusinessLogic.ofEntityManager.ofTrade.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofTrade.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofTrade.ofInterface.ofPlatform;

namespace BusinessLogic.ofEntityManager.ofTrade
{
    public interface IMTCommodityManager : IMStatusManager<MTCommodity>
    {

    }
    public class MTCommodityManager : MStatusManager<MTCommodity>, IEmployerMTCommodityManager, IEmployeeMTCommodityManager, IPlatformMTCommodityManager, IMTCommodityManager
    {
        public MTCommodityManager(IMTCommodityRepository StatusDataRepository,
            IMTCommodityIdFactory mTCommodityIdFactory,
                               IMTCommodityFileFactory StatusFileFactory,
                               IMTCommodityBlobStorage blobStorage,
                            DicConvertFactory<MTCommodity> dicConvertFactory)
            : base(StatusDataRepository, mTCommodityIdFactory, StatusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}