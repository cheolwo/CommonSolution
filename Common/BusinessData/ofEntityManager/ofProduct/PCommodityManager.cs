using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofProduct.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofProduct.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofProduct.ofFileFactory;
using BusinessLogic.ofEntityManager.ofProduct.ofIdFactory;
using BusinessLogic.ofEntityManager.ofProduct.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofProduct.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofProduct.ofInterface.ofPlatform;

namespace BusinessLogic.ofEntityManager.ofProduct
{
    public interface IPCommodityManager : ICommodityManager<PCommodity>
    {

    }
    public class PCommodityManager : CommodityManager<PCommodity>, IEmployerPCommodityManager, IEmployeePCommodityManager, IPlatformPCommodityManager, IPCommodityManager
    {
        private readonly IPCommodityRepository _PCommodityRepository;
        public PCommodityManager(IPCommodityRepository PCommodityRepository,
                               IPCommodityIdFactory PCommodityIdFactory,
                               IPCommodityFileFactory PCommodityFileFactory,
                               IPCommodityBlobStorage blobStorage,
                            DicConvertFactory<PCommodity> dicConvertFactory)
            : base(PCommodityRepository, PCommodityIdFactory, PCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _PCommodityRepository = PCommodityRepository;
        }
    }
}