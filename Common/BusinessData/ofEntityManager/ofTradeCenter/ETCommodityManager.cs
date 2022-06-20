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
    public interface IETCommodityManager : IEStatusManager<ETCommodity>
    {

    }
    public class ETCommodityManager : EStatusManager<ETCommodity>, IEmployerETCommodityManager, IEmployeeETCommodityManager, IPlatformETCommodityManager, IETCommodityManager
    {
        public ETCommodityManager(IETCommodityRepository StatusDataRepository,
            IETCommodityIdFactory eTCommodityIdFactory,
                               IETCommodityFileFactory StatusFileFactory,
                               IETCommodityBlobStorage blobStorage,
                            DicConvertFactory<ETCommodity> dicConvertFactory)
            : base(StatusDataRepository, eTCommodityIdFactory, StatusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}