using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofEntityDTOManager.ofGeneric
{
    public interface ICenterDTORepository<DTO, Model> : ICenterDataRepository<Model>
        where DTO : CenterDTO, new()
        where Model : Center, new()
    {
    }
}