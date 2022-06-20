using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofModel;
using BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofRepository;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofIdFactory;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofDeliveryCenter.ofInterface.ofPlatform;

namespace BusinessLogic.ofEntityManager.ofDeliveryCenter
{
    public interface IDCommodityManager : ICommodityManager<DCommodity>
    {

    }
    public class DCommodityManager : CommodityManager<DCommodity>, IEmployerDCommodityManager, IEmployeeDCommodityManager, IPlatformDCommodityManager, IDCommodityManager
    {
        public DCommodityManager(IDCommodityRepository dcommodityDataRepository,
            IDCommodityIdFactory dCommodityIdFactory,
                                IDCommodityFileFactory dcommodityFileFactory,
                                IDCommodityBlobStorage dCommodityBlobStorage,
                            DicConvertFactory<DCommodity> dicConvertFactory)
            : base(dcommodityDataRepository, dCommodityIdFactory, dcommodityFileFactory, dCommodityBlobStorage, dicConvertFactory)
        {

        }
    }
}