using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployee;
using NMemory;
using NMemory.Tables;

namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployee
{
    public class EmployeeOrderNMemoryDatabase : Database
    {
        public EmployeeOrderNMemoryDatabase()
        {
            var _EmployeeOrderCenters = this.Tables.Create<EmployeeOrderCenter, string>(x=>x.Id, null);
            var _EmployeeOCommoditys = this.Tables.Create<EmployeeOCommodity, string>(x=>x.Id, null);
            var _EmployeeSOCommoditys = this.Tables.Create<EmployeeSOCommodity, string>(x=>x.Id, null);
            var _EmployeeMOCommoditys = this.Tables.Create<EmployeeMOCommodity, string>(x=>x.Id, null);
            var _EmployeeEOCommoditys = this.Tables.Create<EmployeeEOCommodity, string>(x=>x.Id, null);
            EmployeeOrderCenters = _EmployeeOrderCenters;
            EmployeeOCommoditys = _EmployeeOCommoditys;
            EmployeeSOCommoditys = _EmployeeSOCommoditys;
            EmployeeMOCommoditys = _EmployeeMOCommoditys;
            EmployeeEOCommoditys = _EmployeeEOCommoditys;
        }
        public ITable<EmployeeOrderCenter> EmployeeOrderCenters {get; private set;}
        public ITable<EmployeeOCommodity> EmployeeOCommoditys {get; private set;}
        public ITable<EmployeeSOCommodity> EmployeeSOCommoditys {get; private set;}
        public ITable<EmployeeMOCommodity> EmployeeMOCommoditys {get; private set;}
        public ITable<EmployeeEOCommodity> EmployeeEOCommoditys {get; private set;}
    }
}