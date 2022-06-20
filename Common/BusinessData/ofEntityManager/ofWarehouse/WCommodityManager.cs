using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofInterface;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofWarehouse.ofFileFactory;
using BusinessLogic.ofEntityManager.ofWarehouse.ofIdFactory;
using BusinessLogic.ofEntityManager.ofWarehouse.ofInterface.ofCommon;
using BusinessLogic.ofEntityManager.ofWarehouse.ofInterface.ofEmployee;
using BusinessLogic.ofEntityManager.ofWarehouse.ofInterface.ofEmployer;
using BusinessLogic.ofEntityManager.ofWarehouse.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofInterface.ofEmployee;

namespace BusinessLogic.ofEntityManager.ofWarehouse
{
    public class WCommodityManager : CommodityManager<WCommodity>, IEmployerWCommodityManager, IEmployeeWCommodityManager, IPlatformWCommodityManager, IWCommodityManager
    {
        public WCommodityManager(IWCommodityRepository CommodityDataRepository,
            IWCommodityIdFactory wCommodityIdFactory,
                               IWCommodityFileFactory CommodityFileFactory,
                               IWCommodityBlobStorage blobStorage,
                            DicConvertFactory<WCommodity> dicConvertFactory)
            : base(CommodityDataRepository, wCommodityIdFactory, CommodityFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
    public class DividedTagManager : EntityManager<DividedTag>, IEmployerDividedTagManager, IEmployeeDividedTagManager, IPlatformDividedTagManager, IDividedTagManager
    {
        public DividedTagManager(IDividedTagRepository DividedTagDataRepository,
            IDividedTagIdFactory DividedTagIdFactory,
                               IDividedTagFileFactory DividedTagFileFactory,
                               IDividedTagBlobStorage blobStorage,
                            DicConvertFactory<DividedTag> dicConvertFactory)
            : base(DividedTagDataRepository, DividedTagIdFactory, DividedTagFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
    public class DotBarcodeManager : EntityManager<DotBarcode>, IEmployerDotBarcodeManager, IEmployeeDotBarcodeManager, IPlatformDotBarcodeManager, IDotBarcodeManager
    {
        public DotBarcodeManager(IDotBarcodeRepository DotBarcodeDataRepository,
            IDotBarcodeIdFactory DotBarcodeIdFactory,
                               IDotBarcodeFileFactory DotBarcodeFileFactory,
                               IDotBarcodeBlobStorage blobStorage,
                            DicConvertFactory<DotBarcode> dicConvertFactory)
            : base(DotBarcodeDataRepository, DotBarcodeIdFactory, DotBarcodeFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
    public class IncomingTagManager : EntityManager<IncomingTag>, IEmployerIncomingTagManager, IEmployeeIncomingTagManager, IPlatformIncomingTagManager, IIncomingTagManager
    {
        public IncomingTagManager(IIncomingTagRepository IncomingTagDataRepository,
            IIncomingTagIdFactory IncomingTagIdFactory,
                               IIncomingTagFileFactory IncomingTagFileFactory,
                               IIncomingTagBlobStorage blobStorage,
                            DicConvertFactory<IncomingTag> dicConvertFactory)
            : base(IncomingTagDataRepository, IncomingTagIdFactory, IncomingTagFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
    public class LoadFrameManager : EntityManager<LoadFrame>, IEmployerLoadFrameManager, IEmployeeLoadFrameManager, IPlatformLoadFrameManager, ILoadFrameManager
    {
        public LoadFrameManager(ILoadFrameRepository LoadFrameDataRepository,
            ILoadFrameIdFactory LoadFrameIdFactory,
                               ILoadFrameFileFactory LoadFrameFileFactory,
                               ILoadFrameBlobStorage blobStorage,
                            DicConvertFactory<LoadFrame> dicConvertFactory)
            : base(LoadFrameDataRepository, LoadFrameIdFactory, LoadFrameFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
    public class WorkingDeskManager : EntityManager<WorkingDesk>, IEmployerWorkingDeskManager, IEmployeeWorkingDeskManager, IPlatformWorkingDeskManager, IWorkingDeskManager
    {
        public WorkingDeskManager(IWorkingDeskRepository WorkingDeskDataRepository,
            IWorkingDeskIdFactory WorkingDeskIdFactory,
                               IWorkingDeskFileFactory WorkingDeskFileFactory,
                               IWorkingDeskBlobStorage blobStorage,
                            DicConvertFactory<WorkingDesk> dicConvertFactory)
            : base(WorkingDeskDataRepository, WorkingDeskIdFactory, WorkingDeskFileFactory, blobStorage, dicConvertFactory)
        {

        }
    }
}