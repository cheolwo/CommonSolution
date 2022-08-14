using AutoMapper;
using BusinessData.ofDataAccessLayer.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ofMapper
{
    public interface IMappingService
    {
    }
    // Entity 로 Mapping 을 하는 것.
    /*
     *  var ExcellentPageConfig = new MapperConfiguration(cfg => cfg.CreateMap<ExcellentCommoditPageXPathInfo, CommodityPageXPathInfo>());
            var DataCenterPageConfig = new MapperConfiguration(cfg => cfg.CreateMap<DataCenterCommodityPageXPathInfo, CommodityPageXPathInfo>());
            ExcellentPageMapper = new Mapper(ExcellentPageConfig);
            DataCenterPageMapper = new Mapper(DataCenterPageConfig);
     */
    public class EntityMappingService<TSource, TDestination>  where TSource : class where TDestination : class
    {
        private readonly Mapper mapper;
        public EntityMappingService()
        {
            var MappingConfig = new MapperConfiguration(cfg => cfg.CreateMap<TSource, TDestination>());
            mapper = new Mapper(MappingConfig);
        }
        public TDestination MappringResult(TSource source)
        {
            return mapper.Map<TDestination>(source);
        }
    }
    public class MappingService
    {
        protected Mapper mapper;
        public MappingService()
        {

        }
        public DTO BasicMappingDTO<DTO, Model>(Model model) where DTO : class where Model : class
        {
            var MappingConfig = new MapperConfiguration(cfg => cfg.CreateMap<Model, DTO>());
            mapper = new Mapper(MappingConfig);
            return mapper.Map<DTO>(model);
        }
    }
    // Commodity로 Mapping 을 하는 것.
    public class CommodityMappingService
    {
        public CommodityMappingService()
        {
        }
    }
    // Center로 Mapping을 하는 것.
    public class CenterMappingService
    {
        public CenterMappingService()
        {
        }
    }
    // Status로 Mapping을 하는 것.
    public class StatusMappingService
    {
        public StatusMappingService()
        {
        }
    }
    // SStatus로 Mapping을 하는 것.
    public class SStatusMappingService
    {
        public SStatusMappingService()
        {
        }
    }
    // MStatus로 Mapping을 하는 것.
    public class MStatusMappingService
    {
        public MStatusMappingService()
        {
        }
    }
    // EStauts로 Mapping을 하는 것.
    public class EStatusMappingService
    {
        public EStatusMappingService()
        {
        }
    }
    /*
        public class OnChannalMappingService : IOnChannalMappingService
    {
        private readonly Mapper ExcellentPageMapper;
        private readonly Mapper DataCenterPageMapper;
        public OnChannalMappingService()
        {
            var ExcellentPageConfig = new MapperConfiguration(cfg => cfg.CreateMap<ExcellentCommoditPageXPathInfo, CommodityPageXPathInfo>());
            var DataCenterPageConfig = new MapperConfiguration(cfg => cfg.CreateMap<DataCenterCommodityPageXPathInfo, CommodityPageXPathInfo>());
            ExcellentPageMapper = new Mapper(ExcellentPageConfig);
            DataCenterPageMapper = new Mapper(DataCenterPageConfig);
        }
        public CommodityPageXPathInfo ExcellentPageXPathToCommodityPageXPathInfo(ExcellentCommoditPageXPathInfo excellentCommoditPageXPathInfo)
        {
            return ExcellentPageMapper.Map<CommodityPageXPathInfo>(excellentCommoditPageXPathInfo);
        }
        public CommodityPageXPathInfo DataCenterPageXPathInfoToCommodityPageXPathInfo(DataCenterCommodityPageXPathInfo dataCenterCommodityPageXPathInfo)
        {
            return DataCenterPageMapper.Map<CommodityPageXPathInfo>(dataCenterCommodityPageXPathInfo);
        }
    }
     */
}
