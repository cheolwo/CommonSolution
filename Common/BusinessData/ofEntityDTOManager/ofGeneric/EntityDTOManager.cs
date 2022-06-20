using BusienssData.ofDataAccessLayer.ofEntityDTORepository.ofGeneric;
using BusienssData.ofPresentationLayer.ofController.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessLogic.oEntityDTOManager.ofCommon;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace BusinessData.ofEntityDTOManager.ofGeneric
{
    public interface IEntityDTOManager<DTO, Model> : IEntityManager<Model> where DTO : EntityDTO, new() where Model : Entity, new()
    {
        Task<DTO> CreateAsync(DTO entityDTO);
        Task<DTO> UpdateAsync(DTO entityDTO);
        Task<IEnumerable<DTO>> GetToListAsync(EntityQuery<DTO> entityQuery);
        Task DeleteAsync(string id);
        Task<IEnumerable<DTO>> GetToListAsyncByQuery(EntityQuery<DTO> entityQuery);
    }
    public class EntityDTOManager<DTO, Model> : EntityManager<Model>, IEntityDTOManager<DTO, Model> where DTO : EntityDTO, new() where Model : Entity, new()
    {
        private readonly IEntityDTORepository<DTO, Model> _EntityDTODataRepository;
        public EntityDTOManager(IEntityDTORepository<DTO, Model> EntityDataRepository, 
            IEntityIdFactory<Model> EntityIdFactory, 
            IEntityFileFactory<Model> entityFileFactory, 
            IEntityBlobStorage<Model> EntityBlobStorage, 
            DicConvertFactory<Model> DicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, EntityBlobStorage, DicConvertFactory)
        {
            _EntityDTODataRepository = EntityDataRepository;
        }

        public Task<DTO> CreateAsync(DTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DTO>> GetToListAsync(EntityQuery<DTO> entityQuery)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DTO>> GetToListAsyncByQuery(EntityQuery<DTO> entityQuery)
        {
            // EntityQuery 를 Dictionary 로 분류하는 단계
            var QueryDic = entityQuery.GetQueryDictionary(entityQuery);
            var dto = entityQuery.Dto;
            List<DTO> dtos = new();
            var models = await QueryChaining(QueryDic, entityQuery);
       
            return models.ToDtos<Model, DTO>();
        }

        public Task<DTO> UpdateAsync(DTO entityDTO)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<Model>> QueryChaining(Dictionary<QueryCode, List<PropertyInfo>> queryDic, EntityQuery<DTO> entityQuery)
        {
            List<Model> queryModels = new List<Model>();
            List<PropertyInfo> RemaindedQuery = new();
            List<object> Parameters = new();
            string QueryName = FindQueryName(queryDic, RemaindedQuery, Parameters, entityQuery);
            MethodInfo QueryMethod = QueryMatching(QueryName);
            queryModels = (List<Model>)QueryMethod.Invoke(_EntityDataRepository, Parameters.ToArray());
            return queryModels.FileterByRemainedQuery(RemaindedQuery, entityQuery);
        }
     
        public static MethodInfo QueryMatching(string QueryName)
        {
            var methods = typeof(EntityDTORepository<DTO, Model>).GetMethods();
            foreach(var method in methods)
            {
                if(method.Name == QueryName)
                {
                    return method;
                }
            }
            throw new ArgumentException("It is Not Exist Query Method");
        }
        // 쿼리 함수명을 자동으로 생성해주는 모듈이 필요하다.
        // 기본적으로 GetToList + By + PropertyName + Async
        // 선택여부에 따라 Related도 같이 올 수 있음 (EntityQuery 에서 오지는 않음)
        // GetToList + By + PropertyName + Related + Async
        public static string FindQueryName(Dictionary<QueryCode, List<PropertyInfo>> queryDic, 
                                                                            List<PropertyInfo> RemaindedQuery, List<object> Parameters, EntityQuery<DTO> entityQuery)
        {
            string QueryName = string.Empty;
            PropertyInfo FindPropertyInfo;
            var DicValues = queryDic.Values;
            foreach(var valuelist in DicValues)
            {
                foreach(var value  in valuelist)
                {
                    RemaindedQuery.Add(value);
                }
            }
            foreach(var key in queryDic.Keys)
            {
                if(key == QueryCode.Key)
                {
                    var props = queryDic[key];
                    if(props.Count > 0)
                    {
                        FindPropertyInfo = props.FirstOrDefault();
                        RemaindedQuery.Remove(FindPropertyInfo);
                        QueryName = EntityQueryFilter.CreateQueryMethodName(FindPropertyInfo.Name);
                        var parametervalue = FindPropertyInfo.GetValue(entityQuery);
                        Parameters.Add(parametervalue);
                        break;
                    }
                }
                if(key == QueryCode.ForeignKey)
                {
                    var props = queryDic[key];
                    if(props.Count > 0)
                    {
                        FindPropertyInfo = props.FirstOrDefault();
                        RemaindedQuery.Remove(FindPropertyInfo);
                        QueryName = EntityQueryFilter.CreateQueryMethodName(FindPropertyInfo.Name);
                        var parametervalue = FindPropertyInfo.GetValue(entityQuery);
                        Parameters.Add(parametervalue);
                        break;
                    }
                }
                if(key == QueryCode.Time)
                {
                    var props = queryDic[key];
                    FindPropertyInfo = props.FirstOrDefault();
                    RemaindedQuery.Remove(FindPropertyInfo);
                    if (props.Count > 1)
                    {
                        QueryName = EntityQueryFilter.CreateQueryMethodName("BetweenDateTimeAsync");
                        foreach(var prop in props)
                        {
                            var parametervalue = prop.GetValue(entityQuery);
                            Parameters.Add(parametervalue);
                        }        
                        break;
                    }
                    else
                    {
                        QueryName = EntityQueryFilter.CreateQueryMethodName(FindPropertyInfo.Name);
                        var parametervalue = FindPropertyInfo.GetValue(entityQuery);
                        Parameters.Add(parametervalue);
                        break;
                    }
                }
                if(key == QueryCode.String)
                {
                    var props = queryDic[key];
                    if(props.Count > 0)
                    {
                        FindPropertyInfo = props.FirstOrDefault();
                        RemaindedQuery.Remove(FindPropertyInfo);
                        QueryName = EntityQueryFilter.CreateQueryMethodName(FindPropertyInfo.Name);
                        Parameters[0] = FindPropertyInfo.GetValue(entityQuery);
                        break;
                    }
                }
                if(key == QueryCode.Int)
                {
                    var props = queryDic[key];
                    if(props.Count > 0)
                    {
                        FindPropertyInfo = props.FirstOrDefault();
                        RemaindedQuery.Remove(FindPropertyInfo);
                        QueryName = EntityQueryFilter.CreateQueryMethodName(FindPropertyInfo.Name);
                        Parameters[0] = FindPropertyInfo.GetValue(entityQuery);
                        break;
                    }
                }
            }
            return QueryName;
        }
    }
}
