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
    public interface IEGOCManager : IEStatusManager<EGOC>
    {
    }
    public class EGOCManager : EStatusManager<EGOC>, IEmployerEGOCManager, IEmployeeEGOCManager, IPlatformEGOCManager, IEGOCManager
    {
        private readonly IEGOCRepository _EGOCRepository;
        public EGOCManager(IEGOCRepository EGOCRepository,
                               IEGOCIdFactory EGOCIdFactory,
                               IEGOCFileFactory EGOCFileFactory,
                               IEGOCBlobStorage blobStorage,
                            DicConvertFactory<EGOC> dicConvertFactory)
            : base(EGOCRepository, EGOCIdFactory, EGOCFileFactory, blobStorage, dicConvertFactory)
        {
            _EGOCRepository = EGOCRepository;
        }
    }
}
