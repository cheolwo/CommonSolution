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
    public interface IMCommodityManager : ICommodityManager<MCommodity>
    {

    }
    [DataManager(typeof(MCommodity))]
    public class MCommodityManager : CommodityManager<MCommodity>, IEmployerMCommodityManager, IEmployeeMCommodityManager, IPaltformMCommodityManager, IMCommodityManager
    {
        public MCommodityManager(IMCommodityRepository CommodityDataRepository,
                               IMCommodityIdFactory mComodityIdFactory,
                               IMCommodityFileFactory CommodityFileFactory,
                               IMCommodityBlobStorage blobStorage,
                            DicConvertFactory<MCommodity> dicConvertFactory)
            : base(CommodityDataRepository, mComodityIdFactory, CommodityFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}