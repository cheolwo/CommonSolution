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
    public interface IGOCCManager : ICommodityManager<GOCC>
    {
    }
    public class GOCCManager : CommodityManager<GOCC>, IEmployerGOCCManager, IEmployeeGOCCManager, IPlatformGOCCManager, IGOCCManager
    {
        private readonly IGOCCRepository _GOCCRepository;
        public GOCCManager(IGOCCRepository GOCCRepository,
                               IGOCCIdFactory GOCCIdFactory,
                               IGOCCFileFactory GOCCFileFactory,
                               IGOCCBlobStorage blobStorage,
                            DicConvertFactory<GOCC> dicConvertFactory)
            : base(GOCCRepository, GOCCIdFactory, GOCCFileFactory, blobStorage, dicConvertFactory)
        {
            _GOCCRepository = GOCCRepository;
        }
    }
}
