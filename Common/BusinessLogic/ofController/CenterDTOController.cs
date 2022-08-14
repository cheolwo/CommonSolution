using BusienssLogic.ofController.ofGeneric;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofModelExtenstions;
using BusinessData.ofDataContext;
using BusinessData.ofPresentationLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SellerCommon.SellerData.Model;

namespace BusinessLogic.ofController
{
    public class CenterDTOController<DTO, Model> : EntityDTOController<DTO, Model> where DTO : CenterDTO, new() where Model : Center, new()
    {
        public CenterDTOController(ILogger<DTO> logger, DataContext dataContext)
            : base(logger, dataContext)
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
        public override async Task<ActionResult> Delete(DTO dto)
        {
            return await base.Delete(dto);
        }
        [HttpGet]
        public override async Task<IEnumerable<DTO>> GetAlls()
        {
            return await base.GetAlls();
        }
        [HttpPost]
        public override async Task<ActionResult> Post([FromBody] DTO dto)
        {
            if (dto.CenterId != null)
            {
                var model = dto.ConvertToModel<Model, DTO>();
                var value = await model.PostAsync(_dataContext);
                if (value != null)
                {
                    return StatusCode(200);
                }
            }
            throw new ArgumentNullException(nameof(CommodityDTOController<DTO, Model>.Post) + "CenterValue Is Null");
        }
        [HttpPut]
        public override async Task<ActionResult> Put([FromBody] DTO dto)
        {
            return await base.Put(dto);
        }
    }

}
