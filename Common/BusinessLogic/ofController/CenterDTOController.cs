using BusienssLogic.ofController.ofGeneric;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataContext;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BusinessLogic.ofController
{
    public class CenterDTOController<DTO, Model> : EntityDTOController<DTO, Model> where DTO : CenterDTO, new() where Model : Center, new()
    {
        public CenterDTOController(ILogger<DTO> logger, DataContext dataContext)
            :base(logger, dataContext)
        {
        }
    }
    public class CommodityDTOController<DTO, Model> : EntityDTOController<DTO, Model> where DTO : CommodityDTO, new() where Model : Commodity, new()
    {
        public CommodityDTOController(ILogger<DTO> logger, DataContext dataContext)
            : base(logger, dataContext)
        {
        }
        [HttpDelete]
        public override async Task Delete(DTO dto)
        {
           await base.Delete(dto);
        }
        [HttpGet]
        public override async Task<IEnumerable<DTO>> GetAlls()
        {
            return await base.GetAlls();
        }
        [HttpPost]
        public override async Task<ActionResult<DTO>> Post([FromBody] DTO dto)
        {
            return await base.Post(dto);
        }
        [HttpPut]
        public override async Task<ActionResult<DTO>> Put([FromBody] DTO dto)
        {
            return await base.Put(dto);
        }
    }

}
