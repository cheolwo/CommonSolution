using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployee
{
    public class EmployeeWarehouseNMemoryDatabase : Database
    {
        public EmployeeWarehouseNMemoryDatabase()
        {
            var _EmployeeWarehouses = this.Tables.Create<EmployeeWarehouse, string>(x=>x.Id, null);
            var _EmployeeWCommoditys = this.Tables.Create<EmployeeWCommodity, string>(x=>x.Id, null);
            var _EmployeeSWCommoditys = this.Tables.Create<EmployeeSWCommodity, string>(x=>x.Id, null);
            var _EmployeeMWCommoditys = this.Tables.Create<EmployeeMWCommodity, string>(x=>x.Id, null);
            var _EmployeeEWCommoditys = this.Tables.Create<EmployeeEWCommodity, string>(x=>x.Id, null);
            var _EmployeeWorkingDesks = this.Tables.Create<EmployeeWorkingDesk, string>(x=>x.Id, null);
            var _EmployeeLoadFrames = this.Tables.Create<EmployeeLoadFrame, string>(x=>x.Id, null);
            var _EmployeeDividedTags = this.Tables.Create<EmployeeDividedTag, string>(x=>x.Id, null);
            var _EmployeeDotBarcodes = this.Tables.Create<EmployeeDotBarcode, string>(x=>x.Id, null);
            var _EmployeeIncomingTags = this.Tables.Create<EmployeeIncomingTag, string>(x=>x.Id, null);

            EmployeeWarehouses = _EmployeeWarehouses;
            EmployeeWCommoditys = _EmployeeWCommoditys;
            EmployeeSWCommoditys = _EmployeeSWCommoditys;
            EmployeeMWCommoditys = _EmployeeMWCommoditys;
            EmployeeEWCommoditys = _EmployeeEWCommoditys;
            EmployeeWorkingDesks = _EmployeeWorkingDesks;
            EmployeeLoadFrames = _EmployeeLoadFrames;
            EmployeeDividedTags = _EmployeeDividedTags;
            EmployeeDotBarcodes = _EmployeeDotBarcodes;
            EmployeeIncomingTags = _EmployeeIncomingTags;
        }
        public ITable<EmployeeIncomingTag> EmployeeIncomingTags {get; private set;}
        public ITable<EmployeeDotBarcode> EmployeeDotBarcodes {get; private set;}
        public ITable<EmployeeDividedTag> EmployeeDividedTags {get; private set;}
        public ITable<EmployeeLoadFrame> EmployeeLoadFrames {get; private set;}
        public ITable<EmployeeWorkingDesk> EmployeeWorkingDesks {get; private set;}
        public ITable<EmployeeWarehouse> EmployeeWarehouses {get; private set;}
        public ITable<EmployeeWCommodity> EmployeeWCommoditys {get; private set;}
        public ITable<EmployeeSWCommodity> EmployeeSWCommoditys {get; private set;}
        public ITable<EmployeeMWCommodity> EmployeeMWCommoditys {get; private set;}
        public ITable<EmployeeEWCommodity> EmployeeEWCommoditys {get; private set;}
    }
}