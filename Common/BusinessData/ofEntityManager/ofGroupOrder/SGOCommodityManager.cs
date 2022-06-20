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
    public interface ISGOCManager : ISStatusManager<SGOC>
    {
    }
    public class SGOCManager : SStatusManager<SGOC>, IEmployerSGOCManager, IEmployeeSGOCManager, IPlatformSGOCManager, ISGOCManager
    {
        private readonly ISGOCRepository _SGOCRepository;
        public SGOCManager(ISGOCRepository SGOCRepository,
                               ISGOCIdFactory SGOCIdFactory,
                               ISGOCFileFactory SGOCFileFactory,
                               ISGOCBlobStorage blobStorage,
                            DicConvertFactory<SGOC> dicConvertFactory)
            : base(SGOCRepository, SGOCIdFactory, SGOCFileFactory, blobStorage, dicConvertFactory)
        {
            _SGOCRepository = SGOCRepository;
        }
    }
}
