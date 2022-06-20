using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;

namespace BusinessData.ofEntityDTOManager.ofGeneric
{
    public class CenterDTOManager<DTO, Model> : CenterManager<Model>, ICenterDTOManager<DTO, Model> where DTO : CenterDTO, new() where Model : Center, new()
    {
        private readonly ICenterDTORepository<DTO, Model> _CenterDTODataRepository;
        public CenterDTOManager(ICenterDTORepository<DTO, Model> CenterDataRepository,
            ICenterIdFactory<Model> CenterIdFactory,
            ICenterFileFactory<Model> CenterFileFactory,
            IEntityBlobStorage<Model> CenterBlobStorage,
            CenterPasswordHasher<Model> _passwordHashser,
            DicConvertFactory<Model> DicConvertFactory) : base(CenterDataRepository, CenterIdFactory, CenterFileFactory, CenterBlobStorage, DicConvertFactory, _passwordHashser)
        {
            _CenterDTODataRepository = CenterDataRepository;
        }
    }
}
