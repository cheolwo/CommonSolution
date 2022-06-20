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
    public interface ISTCommodityManager : ISStatusManager<STCommodity>
    {

    }
    public class STCommodityManager : SStatusManager<STCommodity>, IEmployerSTCommodityManager, IEmployeeSTCommodityManager, IPlatformSTCommodityManager, ISTCommodityManager
    {
        public STCommodityManager(ISTCommodityRepository StatusDataRepository,
            ISTCommodityIdFactory sTCommodityIdFactory,
                               ISTCommodityFileFactory StatusFileFactory,
                               ISTCommodityBlobStorage blobStorage,
                            DicConvertFactory<STCommodity> dicConvertFactory)
            : base(StatusDataRepository, sTCommodityIdFactory, StatusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}