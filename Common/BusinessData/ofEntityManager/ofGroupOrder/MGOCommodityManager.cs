using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofGroupOrder.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGroupOrder.ofFileFactory;
using BusinessLogic.ofEntityManager.ofGroupOrder.ofIdFactory;
using BusinessLogic.ofEntityManager.ofGroupOrder.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofGroupOrder.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofGroupOrder.ofInterface.ofPlatform;

namespace BusinessLogic.ofEntityManager.ofOrder
{
    public interface IMGOCManager : IMStatusManager<MGOC>
    {
    }
    public class MGOCManager : MStatusManager<MGOC>, IEmployerMGOCManager, IEmployeeMGOCManager, IPlatformMGOCManager, IMGOCManager
    {
        private readonly IMGOCRepository _MGOCRepository;
        public MGOCManager(IMGOCRepository MGOCRepository,
                               IMGOCIdFactory MGOCIdFactory,
                               IMGOCFileFactory MGOCFileFactory,
                               IMGOCBlobStorage blobStorage,
                            DicConvertFactory<MGOC> dicConvertFactory)
            : base(MGOCRepository, MGOCIdFactory, MGOCFileFactory, blobStorage, dicConvertFactory)
        {
            _MGOCRepository = MGOCRepository;
        }
    }
}
