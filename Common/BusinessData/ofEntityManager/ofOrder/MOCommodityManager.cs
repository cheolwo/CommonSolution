using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofDataAccessLayer.ofOrder.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofOrder.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofOrder.ofFileFactory;
using BusinessLogic.ofEntityManager.ofOrder.ofIdFactory;
using BusinessLogic.ofEntityManager.ofOrder.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofOrder.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofOrder.ofInterface.ofPlatform;

namespace BusinessLogic.ofEntityManager.ofOrder
{
    public interface IMOCommodityManager : IMStatusManager<MOCommodity>
    {
    }
    public class MOCommodityManager : MStatusManager<MOCommodity>, IEmployerMOCommodityManager, IEmployeeMOCommodityManager, IPlatformMOCommodityManager, IMOCommodityManager
    {
        private readonly IMOCommodityRepository _MOCommodityRepository;
        public MOCommodityManager(IMOCommodityRepository MOCommodityRepository,
                               IMOCommodityIdFactory MOCommodityIdFactory,
                               IMOCommodityFileFactory MOCommodityFileFactory,
                               IMOCommodityBlobStorage blobStorage,
                            DicConvertFactory<MOCommodity> dicConvertFactory)
            : base(MOCommodityRepository, MOCommodityIdFactory, MOCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _MOCommodityRepository = MOCommodityRepository;
        }
    }
}