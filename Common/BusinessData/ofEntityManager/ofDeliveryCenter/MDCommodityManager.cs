using BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofModel;
using BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofRepository;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofIdFactory;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofInterface.ofPlatform;
using BusinessLogic.ofEntityManager.ofGeneric;

namespace BusinessLogic.ofEntityManager.ofDeliveryCenter
{
    public interface IMDCommodityManager : IMStatusManager<MDCommodity>
    {

    }
    [DataManager(typeof(MDCommodity))]
    public class MDCommodityManager : MStatusManager<MDCommodity>, IEmployerMDCommodityManager, IEmployeeMDCommodityManager, IPlatformMDCommodityManager, IMDCommodityManager
    {
        public MDCommodityManager(IMDCommodityRepository statusDataRepository,     
            IMDCommodityIdFactory mDCommodityIdFatory,
                               IMDCommodityFileFactory statusFileFactory,
                               IMDCommodityBlobStorage blobStorage,
                            DicConvertFactory<MDCommodity> dicConvertFactory)
            : base(statusDataRepository, mDCommodityIdFatory, statusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}