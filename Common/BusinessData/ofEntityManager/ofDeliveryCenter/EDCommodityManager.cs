using BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofModel;
using BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofIdFactory;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofInterface.ofPlatform;

namespace BusinessLogic.ofEntityManager.ofDeliveryCenter
{
    public interface IEDCommodityManager : IEStatusManager<EDCommodity>
    {

    }
    [DataManager(typeof(EDCommodity))]
    public class EDCommodityManager : EStatusManager<EDCommodity>, IEmployerEDCommodityManager, IEmployeeEDCommodityManager, IPlatformEDCommodityManager, IEDCommodityManager
    {
        public EDCommodityManager(IEDCommodityRepository statusDataRepository,
            IEDCommodityIdFactory eDCommodityIdFactory,
                               IEDCommodityFileFactory statusFileFactory,
                               IEDCommodityBlobStorage blobStorage,
                            DicConvertFactory<EDCommodity> dicConvertFactory)
            : base(statusDataRepository, eDCommodityIdFactory, statusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}