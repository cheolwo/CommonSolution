# EveryoneManagesMerchandise
누구나 쉽게 비즈니스를 관리할 수 있는 시스템을 구축중입니다. 

회계, 인사, 주문, 물류, 판매 등의 업무를 볼 수 있도록 구축중입니다.

현재 .Net Standard 프로젝트로 공통단 코드를 먼저 작성하고 있습니다.

개발과 관련한 구체적인 도면 및 설명은 Blog 및 프로세스 명세서를 통해 확인하실 수 있습니다.

https://blog.naver.com/powerqkrcjfd

## 프로세스 명세서
1. 구매대행 관리 시스템
2. 물류대행 관리 시스템
3. 농수산물 수의거래 시스템
4. 주문자 상물처리 프로세스와 상물관리 시스템

## Architecture 및 .Net Standard Project
![image](https://user-images.githubusercontent.com/25167316/169029960-f31c30f9-9381-4f6c-9f8a-b0a5f756755a.png)

## 공통모듈
BusinessData 프로젝트 안에 포함하는 모듈들은 주로 BusinessLogic.EntityManager 라는 모듈이 포함합니다.

BusinessLogic 프로젝트 안에 포함하는 모듈들은 주로 Asp.net Core Web API Server에서 DI 되어 이용됩니다.

BusinessView 프로젝트 안에 포함하는 모듈들은 주로 Asp.net Core Blazor Server에서 DI 되어 이용됩니다.

## BusinessData
### BusinessData 프로젝트의 특징
![image](https://user-images.githubusercontent.com/25167316/169040024-f4517cb5-eb07-45f8-b73e-4048d361a068.png)
1. Model을 Entity, Center, Commodity, Status 로 구분합니다.
2. 모든 Model은 Entity 개체를 상속합니다.
3. 사업장과 관련한 Model은 모두 Center 개체를 상속합니다.
4. 사업장의 상품과 관련한 개체는 모두 Commodity 개체를 상속합니다.
5. 사업장 상품의 상태와 관련한 개체는 모두 Status 개체를 상속합니다.
6. 상품과 관련한 모든 업무를 시작, 중간, 끝으로 구분하며 Status 개체로 S(시작), M(중간), E(끝) 개체를 상속합니다.

### [주요기술]
1. EntityFrameWork Core
2. Fluent API를 활용한 DbContext 생성
3. Repository Pattern 이용
4. EntityTypeConfigration 을 통한 형식 당 테이블 생성
5. Relation 특성과 리플렉션을 통한 DbContext 유추생성

## Entity Example
    public abstract class Entity : IComparable<Entity>, IComparable, IEquatable<Entity>, IComparer
    {
        [Key] public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Container { get; set; }
        public DateTime CreateTime { get; set; }
        public string UserId { get; set; } // 이 부분은 인덱스로 만들어도 괜찮겠다.
        public List<ChangeUser> ChangedUsers { get; set; }
        public List<ImageofInfo> ImageofInfos { get; set; }
        public List<Doc> Docs { get; set; }
    }


## FluentAPI Example

    public class EntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Entity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(c => c.Id).HasMaxLength((int)ConstraintLength.Id);
            builder.Property(c => c.ChangedUsers).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<ChangeUser>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 new ValueComparer<List<ChangeUser>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));

            builder.Property(c => c.ImageofInfos).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<ImageofInfo>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 new ValueComparer<List<ImageofInfo>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));

            builder.Property(c => c.Docs).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<Doc>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 new ValueComparer<List<Doc>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));
        }
    }

## DbContext Example

    public class WarehouseDbContext : DbContext
    {
        private string _connectionstring;
        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options)
            : base(options)
        {

        }
        public WarehouseDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.WarehouseDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
            modelBuilder.ApplyConfiguration(new WCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new SWCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new MWCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new EWCommodityConfiguration());
        }
        public DbSet<DividedTag> DividedTags {get; set;}
        public DbSet<IncomingTag> IncomingTags {get; set;}
        public DbSet<LoadFrame> LoadFrames {get; set;}
        public DbSet<WorkingDesk> WorkingDesks {get; set;}
        public DbSet<DotBarcode> DotBarcodes { get; set; }
    }
    
## EntityDataRepository 모듈 내 Dbcontext 유추코드 Example


    public class EntityDataRepository<TEntity> : IEntityDataRepository<TEntity> where TEntity : Entity, new()
    {
        protected DbContext _DbContext;
        protected readonly TEntity entity = new();
        public EntityDataRepository(DbContext DbContext)
        {
            if (DbContext != null)
            {
                _DbContext = DbContext;
            }
            else 
            { 
                _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(typeof(TEntity)),   
                                                        entity.GetDbConnetionString(typeof(TEntity)));
            }
        }
        public EntityDataRepository()
        {
            _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(typeof(TEntity)), entity.GetDbConnetionString(typeof(TEntity)));
        }
    }


## BusinessLogic
### BusinessLogic 프로젝트의 특징
![image](https://user-images.githubusercontent.com/25167316/169030079-b320aea4-b93c-4869-beab-887d3a89791e.png)
1. Generic 폴더의 EntityManager 라는 모듈이 통합역할을 담당합니다.
2. 상기 Manager 모듈이 Id, Repository, BlobStorage, File 관리역할을 담당합니다.
3. Model 구분과 마찬가지로 Entity-Center-Commodity-Status 로 Manager 모듈을 구분합니다.

## EntityManager Example

    public class EntityManager<TEntity> : IEntityManager<TEntity> where TEntity : Entity, new()
    {
        public readonly IEntityDataRepository<TEntity> _EntityDataRepository;
        protected readonly IEntityIdFactory<TEntity> _EntityIdFactory;
        protected readonly IEntityFileFactory<TEntity> _EntityFileFactory;
        protected readonly IEntityBlobStorage<TEntity> _EntityBlobStorage;
        protected readonly DicConvertFactory<TEntity> _DicConvertFactory;

        public EntityManager(IEntityDataRepository<TEntity> EntityDataRepository,
                            IEntityIdFactory<TEntity> EntityIdFactory,
                            IEntityFileFactory<TEntity> entityFileFactory,
                            IEntityBlobStorage<TEntity> EntityBlobStorage,
                            DicConvertFactory<TEntity> DicConvertFactory
                            )
        {
            _EntityBlobStorage = EntityBlobStorage;
            _EntityIdFactory = EntityIdFactory;
            _EntityDataRepository = EntityDataRepository;
            _EntityFileFactory = entityFileFactory;
            _DicConvertFactory = DicConvertFactory;
        }
    }

생성패턴을 통해 EntityManager 모듈을 만드는 게 어땠을까? 라는 고민이 있습니다. 또한 통합적으로 정형 및 비정형 데이터를 관리한다는 장점이 있지만 객체지향 설계원칙 중 단일책임원칙을 위배하고 있어 어떻게 재설계할지가 고민입니다.

### [주요기술]
1. 특성을 통한 Id 설정
2. Azure Blob Storage (비정형 데이터)
3. Repository (정형 데이터)

## EntityManager.CreateAsync(T) Example

        public virtual async Task<TEntity> CreateAsync(TEntity entity, List<IBrowserFile> files, string connectionString)
        {
            entity.Id = await _EntityIdFactory.CreateAsync(entity);
            entity.CreateTime = DateTime.Now;
            if (files.Count > 0)
            {
                TEntity BlobUploadEntity = await _EntityBlobStorage.UploadAsync(entity, files, connectionString);
                return await _EntityDataRepository.AddAsync(BlobUploadEntity);
            }
            return await _EntityDataRepository.AddAsync(entity);
        }

### [개발예정]
Quartz.net을 통한 배치모듈을 추가할 예정입니다.
https://www.quartz-scheduler.net/documentation/quartz-3.x/quick-start.html#trying-out-the-application-and-adding-jobs

Status 모델과 함께 주로 배치모듈을 이용할 생각입니다.

## BusinessView
### BusinessView 프로젝트의 특징
유스케이스 다이어그램에서 Actor와 소프트웨어 디자인 패턴 중 생성패턴에 영감을 받아 작성된 ActorContext 모듈을 포함합니다. Web API Server와 데이터 통신할 때 이용되는 DTO 개체를 포함합니다. 또한 MVVM 개발패턴에 이용될 ViewModel 개체를 포함합니다.

### 핵심개체
1. ActorContext
2. DTO
3. ViewModel

### ActorContext의 역할
![image](https://user-images.githubusercontent.com/25167316/169028849-bdbf24e6-ef95-4b5b-a191-9385d393a223.png)
1. DTO 적합성 검사 (Fluent Validation)
2. DTO InMemory 저장소 관리 (NMemory)
3. DTO를 통한 Web API Server와 데이터 통신 

## ActorContext Example
    public abstract class ActorContext
    {
        protected ServiceBuilder ServiceBuilder = new();
        protected StorageBuilder StorageBuilder = new();
        protected ValidatorBuilder ValidatorBuilder = new();
        public ActorContext()
        {
            OnServiceBuilder(ServiceBuilder);
            OnValidatorBuilder(ValidatorBuilder);
            OnStrorageBuilder(StorageBuilder);
        }
        protected virtual void OnServiceBuilder(ServiceBuilder serviceBuilder) { }
        protected virtual void OnStrorageBuilder(StorageBuilder storageBuilder) { }
        protected virtual void OnValidatorBuilder(ValidatorBuilder validatorBuilde) { }

        public abstract Task<T> PostAsync<T>(T t) where T :  EntityDTO,  new();
        public abstract Task<T> PutAsync<T>(T t) where T : EntityDTO, new();
        public abstract Task<T> GetByIdAsync<T>(string id) where T : EntityDTO, new();
        public abstract Task DeleteByIdAsync<T>(string id) where T : EntityDTO, new();
        public abstract Task<IEnumerable<T>> GetsAsync<T>() where T : EntityDTO, new();
        public abstract Task<IEnumerable<T>> GetsAsyncByUserId<T>(string userid) where T : EntityDTO, new();
    }
    
## UserActorContext PostAsycn Example
        public override async Task<T> PostAsync<T>(T t)
        {
            if (t == null) { throw new ArgumentNullException(nameof(T)); }

            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            ITable<T> storage = (ITable<T>)StorageBuilder.Get(typeof(T).Name);
            AbstractValidator<T> validator = (AbstractValidator<T>)ValidatorBuilder.Get(typeof(T).Name);

            if (service == null) { throw new NullReferenceException(nameof(DTOService)); }
            if (storage == null) { throw new NullReferenceException(nameof(ITable<T>)); }
            if (validator == null) { throw new NullReferenceException(nameof(AbstractValidator<T>)); }

            var Result = validator.Validate(t);

            if (Result.IsValid)
            {
                T? Value = await service.PostAsync<T>(t);
                if(Value != null) { storage.Insert(Value); return Value; }
                else { throw new NullReferenceException("PostService Value Is Null"); }
            }
            else
            {
                throw new ValidationException("It is Not Validate");
            }
        }

## UserActorContext GetById Example
        public override async Task<T> GetByIdAsync<T>(string id)
        {
            DTOService service = ServiceBuilder.Get(typeof(T).Name);
            ITable<T> storage = (ITable<T>)StorageBuilder.Get(typeof(T).Name);

            if (service == null) { throw new NullReferenceException("Service Is Null So Register Service!"); }
            if (storage == null) { throw new NullReferenceException("Storage Is Null So Register Storage!"); }

            var StorageValue = storage.FirstOrDefault(e => e.EqualsById(id));
            if(StorageValue != null) { return StorageValue; }  
            else
            {
                var ServiceValue = await service.GetByIdAsync<T>(id);
                if(ServiceValue != null ) { return ServiceValue; }
                else { throw new NullReferenceException("Service Value Is Null"); }
            }
        }

### ViewModel의 역할
![image](https://user-images.githubusercontent.com/25167316/169030714-e659ed8d-1780-4ebc-add8-d0fb1e6a55c4.png)
1. INotifyProperyChanged 인터페이스를 통해 상태변화가 반영될 수 있도록 합니다.
2. Entity-Center-Commodity-Status에 따 View 단 프론트 코드를 정형화합니다.
3. EntityPageViewModel 과 EntityPost,Put,Delete,GetsViewModel 로 구분합니다.
4. Get, Detail Mode 를 지원합니다.

## EntityPageViewModel Example
하나의 ViewPage는 하나의 ViewModel 을 가질 수 있도록 하기 위해 만들었습니다. 
하나의 ViewPage에서 Post, Put, Delete, Gets 역할을 수행할 수 있도록 EntityPageViewModel 기 EntityPost, Put, Delete, GetsViewModel을 DI 받습니다.

    public class EntityPageViewModel<TEntity> : BaseViewModel where TEntity : EntityDTO, new()
    {
        public EntityPostViewModel<TEntity> _EntityPostViewModel;
        public EntityPutViewModel<TEntity> _EntityPutViewModel;
        public EntityDeleteViewModel<TEntity> _EntityDeleteViewModel;
        public EntityGetsViewModel<TEntity> _EntityGetsViewModel;
        public EntityPageViewModel(EntityPostViewModel<TEntity> EntityPostViewModel, EntityPutViewModel<TEntity> EntityPutViewModel,
                                            EntityDeleteViewModel<TEntity> EntityDeleteViewModel, EntityGetsViewModel<TEntity> EntityGetViewModel)
        {
            _EntityPostViewModel = EntityPostViewModel;
            _EntityPutViewModel =  EntityPutViewModel;
            _EntityDeleteViewModel = EntityDeleteViewModel;
            _EntityGetsViewModel = EntityGetViewModel;
        }
    }
    
## EntityPostViewModel Example
    public class EntityPostViewModel<TEntity> : BaseEntityViewModel<TEntity> where TEntity : EntityDTO, new()
    {
        public PostPageToGets? postPageToGets {get; set;}
        public EntityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
    }
    
## BaseEntityVieWModel Example
ViewMode와 DTO 프로퍼티를 정적모듈인 PropertyClassification 을 통해 분류하여 Dictionary에 저장해두는 역할을 담당합니다.
Dictionary에 저장해둔 프로퍼티는 View 단에서 이용하여 화면을 구성하는 요소로 사용할 생각입니다.
    
    public class BaseEntityViewModel<TEntity> : BaseViewModel where TEntity : EntityDTO, new()
    {
        public BaseEntityViewModel(ActorContext ActorContext)
        {
            _ActorContext = ActorContext;
            ComponentMode = ComponentMode.Get;
            PropertiesByComponentMode = PropertyClassification.GetPropertiesByComponentMode(ComponentMode, typeof(TEntity));
            InitializedByComponentMode(ComponentMode);
        }   
        public IDictionary<string, PropertyInfo> StringProperty {get; private set;}
        public IDictionary<string, PropertyInfo> IntProperty {get; private set;}
        public IDictionary<string, PropertyInfo> DateTimeProperty {get; private set;}
        public List<PropertyInfo> PropertiesByComponentMode {get; private set;}
    }
    
## BaseViewModel
MVVM 개발패턴에 따라 모든 ViewModel 관련 개체는 결론적으로 BaseViewModel을 상속하고 있습니다.

     public class BaseViewModel : INotifyPropertyChanged
     {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool isBusy = false;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                SetValue(ref isBusy, value);
            }
        }
        public IList<IBrowserFile> Files = new List<IBrowserFile>();
        private void UploadFiles(InputFileChangeEventArgs e)
        {
            foreach (var file in e.GetMultipleFiles())
            {
                files.Add(file);
            }
        }
        public IDictionary<string, Stream> BrowserFileToDTO()
        {
            IDictionary<string, Stream> BrowserFileStreams = new Dictionary<string, Stream>();
            if(Files.Count > 0)
            {
                foreach(var file in Files)
                {
                    BrowserFileStreams.Add(file.Name, file.OpenReadStream());
                }
            }
            return BrowserFileStreams;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected void SetValue<T>(ref T backingFiled, T value, [CallerMemberName] string propertyName =null)
        {
            if (EqualityComparer<T>.Default.Equals(backingFiled, value)) return;
            backingFiled = value;
            OnPropertyChanged(propertyName);
        }
     }

### DTO 의 역할 (DataTransfer Object)
1. 관계성에 속하는 데이터를 포함해서 Query 할 때 1 그리고 N에 해당하는 개체를 Json String 형식으로 받아옵니다.
2. 이후 View단에서 1 또는 N 개체에 해당하는 데이터를 이용할 때 역직렬화 하여 View 단에서 조회할 수 있도록 합니다.
3. 기본적인 DataTranferObject 역할을 수행합니다.

## DTO Example
Model 과 마찬가지로 DTO 또한 모든 DTO 개체는 모두 EntityDTO 개체를 상속받습니다.

    public class EntityDTO : IEntityDTO
    {
        [Get] public string? Id { get; set; }
        [Get] public string? Code { get; set; }
        [Get] public string? Name { get; set; }
        [Detail]public string? Container {get; set;}
        [Detail]public DateTime CreateTime { get; set; }
        [Detail]public string? UserId {get; set;} // 이 부분은 인덱스로 만들어도 괜찮겠다.
        [Detail]public List<ChangeUser>? ChangedUsers {get; set;}
        [Detail]public List<ImageofInfo>? ImageofInfos {get; set;}
        [Detail]public List<Doc>? Docs {get; set;}
        [Detail] public IDictionary<string, Stream> Files {get; set;}

        public void BrowserFileToDTO(IList<IBrowserFile> files, EntityDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public bool EqualsById(object obj)
        {
            throw new NotImplementedException();
        }
    }

유저별로 보여지는 정보가 다를 거라고 생각하여 유저별 DTO 개체를 만들었습니다. 

    public class EmployerWCommodity : EmployerCommodity
    {
        [Get] public string? Type { get; set; }
        [Get] public string? PakcingBarcode { get; set; }
        [Detail] public double? Width { get; set; }
        [Detail] public double? height { get; set; }
        [Detail] public double? length { get; set; }
        [Get] public int Quantity { get; set; }
        [Get] public string? MCommodityId { get; set; }
        [Get] public string? TCommodityId { get; set; }
        [Detail][Many(ViewNameofWarehouse.SWCommodity)] public string? SWCommodities { get; set; }  // 입고
        [Detail][Many(ViewNameofWarehouse.EWCommodity)] public string? EWCommodities { get; set; }  // 출고
        [Detail][Many(ViewNameofWarehouse.MWCommodity)] public string? MWCommodities { get; set; }  // 적재
        [Detail][One(ViewNameofWarehouse.Warehouse)] public string? Warehouse { get; set; }
    }
    
## Model To DTO Example

관계성에 속하는 개체를 포함해서 프론트 단이 백엔드 단에 Query 할 때 
1 그리고 N에 해당하는 개체는 Json String 형식으로 직렬화해서 받아옵니다.

    // 직렬화가 주요 개념
    public class ModelToDTO<Model, DTO> where Model : class where DTO : class
    {
        public static DTO ConvertToDTO(Model model, DTO dto)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = false;
            var ModelProps = typeof(Model).GetProperties();
            var DTOProps = typeof(DTO).GetProperties();
            foreach (var prop in ModelProps)
            {
                var modelvalue = prop.GetValue(model);
                foreach(var dtoprop in DTOProps)
                {
                    if(dtoprop.Name.Equals(prop.Name))
                    {
                        var Many = dtoprop.GetCustomAttribute<ManyAttribute>();
                        var One = dtoprop.GetCustomAttribute<OneAttribute>();
                        if (Many is not null || One is not null)
                        {
                            var dtovalue = JsonConvert.SerializeObject(modelvalue, Formatting.Indented);
                            dtoprop.SetValue(dto, dtovalue);
                            break;
                        }
                        else
                        {
                            dtoprop.SetValue(dto, modelvalue);
                            break;
                        }
                    }
                }
            }
            return dto;
        }
    }
    
## DTO To Model Example
백엔드 서버가 프론트 단을 통해 DTO를 넘겨 받으면 DTOToModel을 통해 역직렬화하여 업무처리를 합니다.

    public class DTOToModel<DTO, Model> where DTO : class where Model : class
    {
        public static Model ConvertToModel(DTO dto, Model model)
        {
            var ModelProps = typeof(Model).GetProperties();
            var DTOProps = typeof(DTO).GetProperties();
            foreach (var dtoprop in DTOProps)
            {
                var dtovalue = dtoprop.GetValue(dto);
                if (dtovalue != null)
                {
                    foreach (var modelprop in ModelProps)
                    {
                        if (dtoprop.Name.Equals(modelprop.Name))
                        {
                            var Many = dtoprop.GetCustomAttribute<ManyAttribute>();
                            var One = dtoprop.GetCustomAttribute<OneAttribute>();
                            if (Many is not null || One is not null)
                            {
                                string JsonDtoValue = (string)dtovalue;
                                var DeserialObject = JsonConvert.DeserializeObject(JsonDtoValue, modelprop.PropertyType);
                                modelprop.SetValue(model, DeserialObject);
                                break;
                            }
                            else
                            {
                                modelprop.SetValue(model, dtovalue);
                                break;
                            }
                        }
                    }
                }
            }
            return model;
        }
    }

### [주요기술]
1. 생성패턴을 통한 ActorContext 생성
2. Model To DTO, DTO To Model Mapper
3. MVVM 개발패턴에 따른 ViewModel
4. NMemory Library
5. FluentValidation.Net Library
6. Get, Detail, One, Many 특성을 통한 DTO 분류
7. PropertyClassification 모듈을 통한 DTO Property 분류

https://nmemory.net/

https://docs.fluentvalidation.net/en/latest/upgrading-to-9.html?highlight=Ivalidationcontext



  
