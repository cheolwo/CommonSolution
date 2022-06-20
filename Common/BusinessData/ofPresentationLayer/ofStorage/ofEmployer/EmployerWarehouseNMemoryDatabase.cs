using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployer;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployer
{
    public class EmployerWarehouseNMemoryDatabase : Database
    {
        public EmployerWarehouseNMemoryDatabase()
        {
            var _EmployerWarehouses = this.Tables.Create<EmployerWarehouse, string>(x=>x.Id, null);
            var _EmployerWCommoditys = this.Tables.Create<EmployerWCommodity, string>(x=>x.Id, null);
            var _EmployerSWCommoditys = this.Tables.Create<EmployerSWCommodity, string>(x=>x.Id, null);
            var _EmployerMWCommoditys = this.Tables.Create<EmployerMWCommodity, string>(x=>x.Id, null);
            var _EmployerEWCommoditys = this.Tables.Create<EmployerEWCommodity, string>(x=>x.Id, null);
            var _EmployerWorkingDesks = this.Tables.Create<EmployerWorkingDesk, string>(x=>x.Id, null);
            var _EmployerLoadFrames = this.Tables.Create<EmployerLoadFrame, string>(x=>x.Id, null);
            var _EmployerDividedTags = this.Tables.Create<EmployerDividedTag, string>(x=>x.Id, null);
            var _EmployerDotBarcodes = this.Tables.Create<EmployerDotBarcode, string>(x=>x.Id, null);
            var _EmployerIncomingTags = this.Tables.Create<EmployerIncomingTag, string>(x=>x.Id, null);

            EmployerWarehouses = _EmployerWarehouses;
            EmployerWCommoditys = _EmployerWCommoditys;
            EmployerSWCommoditys = _EmployerSWCommoditys;
            EmployerMWCommoditys = _EmployerMWCommoditys;
            EmployerEWCommoditys = _EmployerEWCommoditys;
            EmployerWorkingDesks = _EmployerWorkingDesks;
            EmployerLoadFrames = _EmployerLoadFrames;
            EmployerDividedTags = _EmployerDividedTags;
            EmployerDotBarcodes = _EmployerDotBarcodes;
            EmployerIncomingTags = _EmployerIncomingTags;
        }
        public ITable<EmployerIncomingTag> EmployerIncomingTags {get; private set;}
        public ITable<EmployerDotBarcode> EmployerDotBarcodes {get; private set;}
        public ITable<EmployerDividedTag> EmployerDividedTags {get; private set;}
        public ITable<EmployerLoadFrame> EmployerLoadFrames {get; private set;}
        public ITable<EmployerWorkingDesk> EmployerWorkingDesks {get; private set;}
        public ITable<EmployerWarehouse> EmployerWarehouses {get; private set;}
        public ITable<EmployerWCommodity> EmployerWCommoditys {get; private set;}
        public ITable<EmployerSWCommodity> EmployerSWCommoditys {get; private set;}
        public ITable<EmployerMWCommodity> EmployerMWCommoditys {get; private set;}
        public ITable<EmployerEWCommodity> EmployerEWCommoditys {get; private set;}
    }
}