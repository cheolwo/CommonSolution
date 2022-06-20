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
    public interface IEOCommodityManager : IEStatusManager<EOCommodity>
    {
    }
    public class EOCommodityManager : EStatusManager<EOCommodity>, IEmployerEOCommodityManager, IEmployeeEOCommodityManager, IPlatformEOCommodityManager, IEOCommodityManager
    {
        private readonly IEOCommodityRepository _EOCommodityRepository;
        public EOCommodityManager(IEOCommodityRepository EOCommodityRepository,
                               IEOCommodityIdFactory EOCommodityIdFactory,
                               IEOCommodityFileFactory EOCommodityFileFactory,
                               IEOCommodityBlobStorage blobStorage,
                            DicConvertFactory<EOCommodity> dicConvertFactory)
            : base(EOCommodityRepository, EOCommodityIdFactory, EOCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _EOCommodityRepository = EOCommodityRepository;
        }
    }
}