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
    public interface ITCommodityManager : ICommodityManager<TCommodity>
    {

    }
    public class TCommodityManager : CommodityManager<TCommodity>, IEmployerTCommodityManager, IEmployeeTCommodityManager, IPlatformTCommodityManager, ITCommodityManager
    {
        public TCommodityManager(ITCommodityRepository CommodityDataRepository,
            ITCommodityIdFactory TCommodityIdFactory,
                               ITCommodityFileFactory CommodityFileFactory,
                               ITCommodityBlobStorage blobStorage,
                            DicConvertFactory<TCommodity> dicConvertFactory)
            : base(CommodityDataRepository, TCommodityIdFactory, CommodityFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}