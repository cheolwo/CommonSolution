using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofModelExtenstions;
using BusinessData.ofDataContext;
using BusinessData.ofPresentationLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BusienssLogic.ofController.ofGeneric
{
    // 여기 친구는 Rouing 을 할 정도가 아니야
    // Rouing은 구체적인 이름이 붙어야 돼.
    public interface IEntityDTOController<DTO, Model> where DTO : EntityDTO, new() where Model : Entity, new()
    {
        Task<ActionResult<DTO>> Post([FromBody] DTO dto);
        Task<ActionResult<DTO>> Put([FromBody] DTO dto);
        Task Delete(DTO dtO);
        Task<IEnumerable<DTO>> GetAlls();
    }

    public class EntityDTOController<DTO, Model> : ControllerBase, IEntityDTOController<DTO, Model> where DTO : EntityDTO, new() where Model : Entity, new()
    {
        protected readonly ILogger<DTO> _logger;
        protected readonly DataContext _dataContext;
        public EntityDTOController(ILogger<DTO> logger, DataContext dataContext)
        {
            _logger = logger;
            _dataContext = dataContext;
        }
        [HttpGet]
        public virtual async Task<IEnumerable<DTO>> GetAlls()
        {
            // 여기는 중간 저장소를 볼 게 아니라 바로 DB 쪽 데이터에서 가져오도록 하자.
            _logger.LogInformation(nameof(EntityDTOController<DTO, Model>.GetAlls));
            IEnumerable<Model> models = await _dataContext.GetsAsync<Model>();
            List<DTO> dtos = new();
            int Count = models.Count();
            if (Count > 0)
            {
                foreach(var model in models)
                {
                    var dto = model.ConvertToDTO<DTO, Model>();
                    dtos.Add(dto);
                }
                return dtos;
            }
            return dtos;
        }
        [HttpPost]
        public virtual async Task<ActionResult<DTO>> Post([FromBody] DTO dto)
        {
            _logger.LogInformation(nameof(EntityDTOController<DTO, Model>.Post));
            var model = dto.ConvertToModel<Model, DTO>();
            var newModel = await model.PostAsync(_dataContext);
            if (newModel != null)
            {
                return newModel.ConvertToDTO<DTO, Model>();
            }
            throw new ArgumentException("Post Failed");
        }
        [HttpPut]
        public virtual async Task<ActionResult<DTO>> Put([FromBody] DTO dto)
        {
            _logger.LogInformation(nameof(EntityDTOController<DTO, Model>.Put));
            var model = dto.ConvertToModel<Model, DTO>();
            var updatedModel = await model.PutAsync(_dataContext);
            if (updatedModel == null)
            {
                return BadRequest();
            }
            // 중간 저장소에 같은 Id를 가지는 값이 있다면 삭제하고 삽입
            return updatedModel.ConvertToDTO<DTO, Model>();
        }
        [HttpDelete]
        public virtual async Task Delete(DTO dto)
        {
            _logger.LogInformation(nameof(EntityDTOController<DTO, Model>.Delete));
            var model = dto.ConvertToModel<Model, DTO>();
            if (model.Id != null)
            {
                await model.DeleteAsync(_dataContext);
            }
            else
            {
                throw new ArgumentException("Delete");
            }
        }
    }
}