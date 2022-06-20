using System.Threading.Tasks;
using BusinessData.ofCommon.ofKapt;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofInterface;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofEntityManager.ofWarehouse.ofIdFactory;
using BusinessLogic.ofEntityManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofWarehouse.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofWarehouse.ofInterface.ofPlatform;

namespace BusinessLogic.ofEntityManager.ofWarehouse
{
    public class WarehouseRelatedCountViewModel
    {
        public Warehouse Warehouse { get; set; }
        public int CountCommodity { get; set; }
        public int CountSWCommodity { get; set; }
        public int CountMWCommodity { get; set; }
        public int CountEWCommodity { get; set; }
        public WarehouseRelatedCountViewModel(Warehouse warehouse, int CountCommodity, int CountSWCommodity,
            int CountMWCommmodity, int CountEWCommodity)
        {
            Warehouse = warehouse;
            this.CountCommodity = CountCommodity;
            this.CountSWCommodity = CountSWCommodity;
            this.CountMWCommodity = CountMWCommmodity;
            this.CountEWCommodity = CountEWCommodity;
        }
    }
    public class WarehouseManager : CenterManager<Warehouse>, IEmployerWarehouseManager, IEmployeeWarehouseManager, IPlatformWarehouseManager, IWarehouseManager
    {
        private readonly IWarehouseRepository _WarehouseRepository;
        private readonly IWarehouseIdFactory _WarehouseIdFactory;
        private readonly IWarehouseBlobStorage _WarehouseBlobStorage;
        private readonly IWarehouseFileFactory _WarehouseFileFactory;
        public WarehouseManager(IWarehouseRepository WarehouseRepository,
                               IWarehouseIdFactory WarehouseIdFactory,
                               IWarehouseFileFactory WarehouseFileFactory,
                               IWarehouseBlobStorage WarehouseBlobStorage,
                            DicConvertFactory<Warehouse> dicConvertFactory,
                            CenterPasswordHasher<Warehouse> centerPasswordHasher)
            : base(WarehouseRepository, WarehouseIdFactory, WarehouseFileFactory, WarehouseBlobStorage, dicConvertFactory, centerPasswordHasher)
        {
            _WarehouseRepository = WarehouseRepository;
            _WarehouseIdFactory = WarehouseIdFactory;
            _WarehouseBlobStorage = WarehouseBlobStorage;
            _WarehouseFileFactory = WarehouseFileFactory;
        }
        public async Task<bool> WarehouseLoginAsync(string LoginId, string Password)
        {
            Warehouse warehouse = await base.LoginAsync(LoginId, Password);
            if(warehouse != null)
            {
                return true;
            }
            else { return false; }
        }
        public async Task<Warehouse> CreateByKAptAndGOC(KAptBasicInfo kAptBasicInfo, GOC groupOrderCenter)
        {
            var newWarehouse = InitByKaptAndGOC(kAptBasicInfo, groupOrderCenter);
            newWarehouse.Id = await _WarehouseIdFactory.CreateByKapt(newWarehouse, kAptBasicInfo);
            return await _WarehouseRepository.AddAsync(newWarehouse);    
        }
        private Warehouse InitByKaptAndGOC(KAptBasicInfo kAptBasicInfo, GOC groupOrderCenter)
        {
            Warehouse warehouse = new();
            /*특정한 데이터 대입을 처리한다*/
            warehouse.UserId = groupOrderCenter.Id; // 핵심사항.
            warehouse.Name = kAptBasicInfo.Name;
            warehouse.Address = kAptBasicInfo.StreetAddress;
            warehouse.CountryCode = "KR";
            warehouse.FaxNumber = kAptBasicInfo.ManagementOfficeFax;
            warehouse.PhoneNumber = kAptBasicInfo.ManagementOfficePhoneNumber;
            return warehouse;
        }
        // Id로 Entity를 Load 하는 단계
        // Entity Password와 입력 Password를 비교하는 단계
        // 일치할 시 Entity를 반환하고 아닌 경우 예외처리하는 단계를 포함하는
        // CenterManager 로그인 메서드를 오버라이딩하여
        // Entity가 반환된 경우 관련 데이터를 같이 로드하는 것을 특징으로 하는 WarehouseManager 로그인 메서드
        public async Task<Warehouse> LoginWithDataAsync(string LoginId, string Password)
        {
            Warehouse warehouse = await base.LoginAsync(LoginId, Password);
            warehouse = await _WarehouseRepository.GetRelatedData(warehouse); 
            return warehouse;
        }
    }

    //public class WorkingDeskManager : EntityManager<WorkingDesk>
    //{
    //    public WorkingDeskManager(IWorkingDeskRepository CenterDataRepository,
    //        IWorkingDeskIdFactory workingDeskIdFactory,
    //                           IWorkingDeskFileFactory CenterFileFactory,
    //                           IWorkingDeskBlobStorage blobStorage,
    //                        DicConvertFactory<WorkingDesk> dicConvertFactory)
    //        : base(CenterDataRepository, workingDeskIdFactory, CenterFileFactory, blobStorage, dicConvertFactory)
    //    {

    //    }
    //}
    //public class DotBarcodeManager : EntityManager<DotBarcode>
    //{
    //    public DotBarcodeManager(IDotBarcodeRepository CenterDataRepository,
    //        IDotBarcodeIdFactory dotBarcodeIdFactory,
    //                           IDotBarcodeFileFactory CenterFileFactory,
    //                           IEntityBlobStorage<DotBarcode> blobStorage,
    //                        DicConvertFactory<DotBarcode> dicConvertFactory)
    //        : base(CenterDataRepository, dotBarcodeIdFactory, CenterFileFactory, blobStorage, dicConvertFactory)
    //    {

    //    }
    //}
}