using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofDataAccessLayer.ofOrder.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofOrder.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofOrder.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofOrder.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofOrder.ofInterface.ofPlatform;
using BusinessLogic.ofEntityManager.ofOrder.ofFileFactory;
using BusinessLogic.ofEntityManager.ofOrder.ofIdFactory;

namespace BusinessLogic.ofEntityManager.ofOrder
{
    public interface ISOCommodityManager : ISStatusManager<SOCommodity>
    {
    }
    public class SOCommodityManager : SStatusManager<SOCommodity>, IEmployerSOCommodityManager, IEmployeeSOCommodityManager, IPlatformSOCommodityManager, ISOCommodityManager
    {
        private readonly ISOCommodityRepository _SOCommodityRepository;
        public SOCommodityManager(ISOCommodityRepository SOCommodityRepository,
                               ISOCommodityIdFactory SOCommodityIdFactory,
                               ISOCommodityFileFactory SOCommodityFileFactory,
                               ISOCommodityBlobStorage blobStorage,
                            DicConvertFactory<SOCommodity> dicConvertFactory)
            : base(SOCommodityRepository, SOCommodityIdFactory, SOCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _SOCommodityRepository = SOCommodityRepository;
        }
    }
}