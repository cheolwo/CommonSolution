using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployee;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployee
{
    public class EmployeeProductNMemoryDatabase : Database
    {
        public EmployeeProductNMemoryDatabase()
        {
            var _EmployeeProductCenters = this.Tables.Create<EmployeeProductCenter, string>(x=>x.Id, null);
            var _EmployeePCommoditys = this.Tables.Create<EmployeePCommodity, string>(x=>x.Id, null);
            var _EmployeeSPCommoditys = this.Tables.Create<EmployeeSPCommodity, string>(x=>x.Id, null);
            var _EmployeeMPCommoditys = this.Tables.Create<EmployeeMPCommodity, string>(x=>x.Id, null);
            var _EmployeeEPCommoditys = this.Tables.Create<EmployeeEPCommodity, string>(x=>x.Id, null);
            var _EmployeeProductLands = this.Tables.Create<EmployeeProductLand, string>(x=>x.Id, null);
            var _EmployeeProducters = this.Tables.Create<EmployeeProducter, string>(x=>x.Id, null);
            
            EmployeeProductCenters = _EmployeeProductCenters;
            EmployeePCommoditys = _EmployeePCommoditys;
            EmployeeSPCommoditys= _EmployeeSPCommoditys;
            EmployeeMPCommoditys = _EmployeeMPCommoditys;
            EmployeeEPCommoditys = _EmployeeEPCommoditys;
            EmployeeProductLands = _EmployeeProductLands;
            EmployeeProducters = _EmployeeProducters;
        }
        public ITable<EmployeeProductCenter> EmployeeProductCenters {get; private set;}
        public ITable<EmployeePCommodity> EmployeePCommoditys {get; private set;}
        public ITable<EmployeeSPCommodity> EmployeeSPCommoditys {get; private set;}
        public ITable<EmployeeMPCommodity> EmployeeMPCommoditys {get; private set;}
        public ITable<EmployeeEPCommodity> EmployeeEPCommoditys {get; private set;}
        public ITable<EmployeeProductLand> EmployeeProductLands {get; private set;}
        public ITable<EmployeeProducter> EmployeeProducters {get; private set;}
    }
}