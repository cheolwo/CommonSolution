using System.Threading.Tasks;
using BusinessData.ofCommon.ofKapt;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessLogic.ofEntityManager.ofGeneric;

namespace BusinessLogic.ofEntityManager.ofWarehouse
{
    public interface IWarehouseManager : ICenterManager<Warehouse>
    {
        Task<Warehouse> LoginWithDataAsync(string LoginId, string Password);
        Task<bool> WarehouseLoginAsync(string LoginId, string Password);
        Task<Warehouse> CreateByKAptAndGOC(KAptBasicInfo kAptBasicInfo, GOC groupOrderCenter);
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