using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessData.ofDataContext
{
    public class DataContextAttribute : Attribute
    {
        private Type t;
        public DataContextAttribute(Type type)
        {
            t = type;
        }
        public Type T
        {
            get => t;
        }
    }
    // IServiceScopeFactory is always a Singleton but the IServiceProvider can vary based on the lifetime of the containing class.
    /*
        public class Singleton : ISingleton 
        {
            private readonly IServiceScopeFactory scopeFactory;

            public Singleton(IServiceScopeFactory scopeFactory)
            {
                this.scopeFactory = scopeFactory;
            }

            public void MyMethod() 
            {
                using(var scope = scopeFactory.CreateScope()) 
                {
                    var db = scope.ServiceProvider.GetRequiredService<DbContext>();

                    // when we exit the using block,
                    // the IServiceScope will dispose itself 
                    // and dispose all of the services that it resolved.
                }
            }
        }
    */
    /*
     Controller 에는 SeviceProvider 가 주입 되도록 한다.
     그래야 Model 개체에서 확장 메서드를 통해 DataContext에 접근할 수 있기 때문이다.
    */
    /*
        IMemoryCache(Singleton)
        IServiceScopeFactory, ---> DbContext, BackUpDbContext
        IServiceProvider ----> serviceProvider.GetRequiredService<DataContext>();
        // 이 위에 DataContext 가 업무단위별로 달라지는 면이 있으니까 Warehouse, GroupOrder
        등으로 나눠 논 것이지.
    */
    // 사용자 Db 의 Options 을 저장하는 경우 그 데이터와 Mapping 하는 논리가 필요하다.
    public class DataContextOptions
    {
        private bool _IsUseInMemory;
        private bool _IsDistributeCache;
        private bool _IsSnsAlarm;
        private bool _IsKakaoAlarm;
        private bool _IsEamliAlarm;
        public bool IsUseInMemory
        {
            get => _IsUseInMemory;
            set => value;
        }
        public bool IsDistributeCache
        {
            get => _IsDistributeCache;
            set => value;
        }
        public bool IsSnsAlarm
        {
            get => _IsSnsAlarm;
            set => value;
        }
        public bool IsKaKaoAlarm
        {
            get => _IsKakaoAlarm;
            set => value;
        }
        public bool IsEmaliAlarm
        {
            get => _IsEamliAlarm;
            set => value;
        }
        public DataContextOptions(Func<DataContextOptions> options)
        {
            options.Invoke(this);
        }
    }
    public abstract class DataContext
    {
        protected EntityManagerBuilder entityManagerBuilder = new();
        protected readonly IMemoryCache _MemoryCache;
        protected readonly IDistributedCache _DistributedCache;
        protected readonly IServiceScopeFactory _ServiceScopeFactory;
        protected readonly IServiceProvicer _ServiceProvider;
        public DataContext(IMemoryCache memoryCache, IDistributedCache distributedCache, 
        IServiceScopeFactory serviceScopeFactory, IServiceProvider serviceProvider)
        {
            _MemoryCache = memoryCache;
            _DistributedCache = distributedCache;
            _ServiceScopeFactory = serviceScopeFactory;
            _ServiceProvider = serviceProvider;
            OnConfigureEntityBlobStorage(entityManagerBuilder);
            OnConfigureEntityFile(entityManagerBuilder);
            OnConfigureEntityId(entityManagerBuilder);
            OnConfigureEntityRepository(entityManagerBuilder);
        }
        protected abstract void OnEntityIdBuilder(EntityManagerBuilder entityManagerBuilder);
        protected abstract void OnEntityBlobStorageBuilder(EntityManagerBuilder entityManagerBuilder);
        protected abstract void OnEntityRepositoryBuilder(EntityManagerBuilder entityManagerBuilder);
        protected abstract void OnEntityExcelBuilder(EntityManagerBuilder entityManagerBuilder);
        protected abstract void OnEntityPDFBuilder(EntityManagerBuilder entityManagerBuilder);

        public abstract Task<T> PostAsync<T>(T t) where T : Entity;
        public abstract Task<T> PutAsync<T>(T t) where T : Entity;
        public abstract Task<T> GetByIdAsync<T>(string id) where T : Entity;
        public abstract Task DeleteByIdAsync<T>(string id) where T : Entity;
        public abstract Task<IEnumerable<T>> GetsAsync<T>() where T : Entity;
    }
    public class EntityManagerBuilder
    {
        // 여기서 string 값이 될 예로 nameof(Warehouse), nameof(WCommodity)... 등이 있다.
        private Dictionary<string, IEntityDataRepository> DicEntityDataRepository = new();
        private Dictionary<string, IEntityIdFactory> DicEntityIdFactory = new();
        private Dictionary<string, IEntityBlobStorage> DicEntityBlobStorage = new();
        private Dictionary<string, IEntityFileFactory> DicEntityFileFactory = new();
        public virtual void ApplyEntityDataRepository(string nameofEntityDataRepository, IEntityDataRepository entityDataRepository)
        {
            DicEntityDataRepository.Add(nameofEntityDataRepository, entityDataRepository);
        }
        public virtual void ApplyEntityIdFactory(string nameofEntityIdFactory, IEntityIdFactory entityIdFactory) 
        {
            DicEntityIdFactory.Add(nameofEntityIdFactory, entityIdFactory);
        }
        public virtual void ApplyEntityFileFactory(string nameofEntityFileFactory, IEntityFileFactory entityFileFactory) 
        {
            DicEntityFileFactory.Add(nameofEntityFileFactory, entityFileFactory);
        }
        public virtual void ApplysEntityBlobStorage(string nameofEntityBlobStorage, IEntityBlobStorage entityBlobStorage)
        {
            DicEntityBlobStorage.Add(nameofEntityBlobStorage, entityBlobStorage);
        }
        public IEntityDataRepository GetEntityDataRepository(string name)
        {
            return DicEntityDataRepository[name]
                   ?? throw new ArgumentNullException("Not Included");
        }
        public IEntityIdFactory GetEntityIdFactory(string name)
        {
            return DicEntityIdFactory[name]
                   ?? throw new ArgumentNullException("Not Included");
        }
        public IEntityBlobStorage GetEntityBlobStorage(string name)
        {
            return DicEntityBlobStorage[name]
                   ?? throw new ArgumentNullException("Not Included");
        }
        public IEntityFileFactory GetEntityFileFactory(string name)
        {
            return DicEntityFileFactory[name]
                   ?? throw new ArgumentNullException("Not Included");
        }
    }
    public interface IEntityIdConfiguration<TEntity> where TEntity : Entity
    {
        void Configure(EntityIdBuilder<TEntity> builder);
    }
    public interface IEntityFileConfiguration<TEntity> where TEntity : Entity
    {
        void Configure(EntityFileBuilder<TEntity> builder);
    }
    public interface IEntityBlobConfiguration<TEntity> where TEntity : Entity
    {
        void Configure(EntityBlobStorageBuilder<TEntity> builder);
    }
    public class EntityIdConfiguration<TEntity> : IEntityIdConfiguration<TEntity> where TEntity : Entity
    {
        public void Configure(EntityIdBuilder<TEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
    public class EntityFileConfiguration<TEntity> : IEntityFileConfiguration<TEntity> where TEntity : Entity
    {
        public void Configure(EntityFileBuilder<TEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
    public class EntityBlobStorageConfiguration<TEntity> : IEntityBlobConfiguration<TEntity> where TEntity : Entity
    {
        public void Configure(EntityBlobStorageBuilder<TEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
    public class EntityIdBuilder<TEntity> where TEntity : Entity
    {
        
    }
    public class EntityFileBuilder<TEntity> where TEntity : Entity
    {

    }
    public class EntityBlobStorageBuilder<TEntity> where TEntity : Entity
    {

    }
}
