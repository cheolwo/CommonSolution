using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee;
using NMemory;
using NMemory.Tables;

namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployee
{
    public class EmployeeMarketNMemoryDatabase : Database
    {
        public EmployeeMarketNMemoryDatabase()
        {
            var _EmployeeMarkets = this.Tables.Create<EmployeeMarket, string>(x=>x.Id, null);
            var _EmployeePlatMarkets = this.Tables.Create<EmployeePlatMarket, string>(x=>x.Id, null);
            var _EmployeeMCommoditys = this.Tables.Create<EmployeeMCommodity, string>(x=>x.Id, null);
            var _EmployeeSMCommoditys = this.Tables.Create<EmployeeSMCommodity, string>(x=>x.Id, null);
            var _EmployeeMMCommoditys = this.Tables.Create<EmployeeMMCommodity, string>(x=>x.Id, null);
            var _EmployeeEMCommoditys = this.Tables.Create<EmployeeEMCommodity, string>(x=>x.Id, null);
            EmployeeMarkets = _EmployeeMarkets;
            EmployeePlatMarkets = _EmployeePlatMarkets;
            EmployeeMCommoditys = _EmployeeMCommoditys;
            EmployeeMMCommoditys = _EmployeeMMCommoditys;
            EmployeeSMCommoditys = _EmployeeSMCommoditys;
            EmployeeEMCommoditys = _EmployeeEMCommoditys;
        }
        public ITable<EmployeeMarket> EmployeeMarkets {get; private set;}
        public ITable<EmployeePlatMarket> EmployeePlatMarkets {get; private set;}
        public ITable<EmployeeMCommodity> EmployeeMCommoditys {get; private set;}
        public ITable<EmployeeSMCommodity> EmployeeSMCommoditys {get; private set;}
        public ITable<EmployeeMMCommodity> EmployeeMMCommoditys {get; private set;}
        public ITable<EmployeeEMCommodity> EmployeeEMCommoditys {get; private set;}
    }
}