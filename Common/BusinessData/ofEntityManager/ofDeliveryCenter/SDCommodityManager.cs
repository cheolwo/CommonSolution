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
    public interface ISDCommodityManager : ISStatusManager<SDCommodity>
    {
        
    }
    [DataManager(typeof(SDCommodity))]
    public class SDCommodityManager : SStatusManager<SDCommodity>, IEmployerSDCommodityManager, IEmployeeSDCommodityManager, IPlatformSDCommodityManager, ISDCommodityManager
    {
        public SDCommodityManager(ISDCommodityRepository statusDataRepository, 
                                ISDCommodityIdFactory sDCommodityIdFactory,
                                ISDCommodityFileFactory statusFileFactory,
                                ISDCommodityBlobStorage blobStorage,
                            DicConvertFactory<SDCommodity> dicConvertFactory)
            : base(statusDataRepository, sDCommodityIdFactory, statusFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}