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
    public interface IEMCommodityManager : IEStatusManager<EMCommodity>
    {

    }
    [DataManager(typeof(EMCommodity))]
    public class EMCommodityManager : EStatusManager<EMCommodity>, IEmployerEMCommodityManager, IEmployeeEMCommodityManager, IPaltformEMCommodityManager, IEMCommodityManager
    {
        public EMCommodityManager(IEMCommodityRepository statusDataRepository,
            IEMCommodityIdFactory eMCommodityIdFactory,
                               IEMCommodityFileFactory statusFileFactory,
                               IEMCommodityBlobStorage blobStorage,
                            DicConvertFactory<EMCommodity> dicConvertFactory)
            : base(statusDataRepository, eMCommodityIdFactory, statusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}