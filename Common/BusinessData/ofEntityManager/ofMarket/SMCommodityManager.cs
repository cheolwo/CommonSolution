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
    public interface ISMCommodityManager : ISStatusManager<SMCommodity>
    {

    }
    [DataManager(typeof(SMCommodity))]
    public class SMCommodityManager : SStatusManager<SMCommodity>, IEmployerSMCommodityManager, IEmployeeSMCommodityManager, IPaltformSMCommodityManager, ISMCommodityManager
    {
        public SMCommodityManager(ISMCommodityRepository statusDataRepository,
            ISMCommodityIdFactory sMCommodityIdFactory,
                               ISMCommodityFileFactory statusFileFactory,
                               ISMCommodityBlobStorage blobStorage,
                            DicConvertFactory<SMCommodity> dicConvertFactory)
            : base(statusDataRepository, sMCommodityIdFactory, statusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}