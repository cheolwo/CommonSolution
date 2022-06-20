using BusinessData.ofProduct.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofProduct.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofProduct.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofProduct.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofProduct.ofInterface.ofPlatform;
using BusinessLogic.ofEntityManager.ofProduct.ofFileFactory;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic.ofEntityManager.ofProduct.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;

namespace BusinessLogic.ofEntityManager.ofProduct
{
    public interface IMPCommodityManager : IMStatusManager<MPCommodity>
    {

    }
    public class MPCommodityManager : MStatusManager<MPCommodity>, IEmployerMPCommodityManager, IEmployeeMPCommodityManager, IPlatformMPCommodityManager, IMPCommodityManager
    {
        private readonly IMPCommodityRepository _MPCommodityRepository;
        public MPCommodityManager(IMPCommodityRepository MPCommodityRepository,
                               IMPCommodityIdFactory MPCommodityIdFactory,
                               IMPCommodityFileFactory MPCommodityFileFactory,
                               IMPCommodityBlobStorage blobStorage,
                            DicConvertFactory<MPCommodity> dicConvertFactory)
            : base(MPCommodityRepository, MPCommodityIdFactory, MPCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _MPCommodityRepository = MPCommodityRepository;
        }

        public Task<string> CreateIdByRelationEntity(MPCommodity entity)
        {
            throw new System.NotImplementedException();
        }

        public List<MPCommodity> SetEntityId(List<MPCommodity> entities, int count)
        {
            throw new System.NotImplementedException();
        }

    }
}