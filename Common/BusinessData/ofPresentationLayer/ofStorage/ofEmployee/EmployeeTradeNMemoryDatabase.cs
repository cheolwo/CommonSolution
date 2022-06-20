using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployee;
using NMemory;
using NMemory.Tables;

namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployee
{
    public class EmployeeTradeNMemoryDatabase : Database
    {
        public EmployeeTradeNMemoryDatabase()
        {
            var _EmployeeTradeCenters = this.Tables.Create<EmployeeTradeCenter, string>(x=>x.Id, null);
            var _EmployeeTCommoditys = this.Tables.Create<EmployeeTCommodity, string>(x=>x.Id, null);
            var _EmployeeSTCommoditys = this.Tables.Create<EmployeeSTCommodity, string>(x=>x.Id, null);
            var _EmployeeMTCommoditys = this.Tables.Create<EmployeeMTCommodity, string>(x=>x.Id, null);
            var _EmployeeETCommoditys = this.Tables.Create<EmployeeETCommodity, string>(x=>x.Id, null);
            EmployeeTradeCenters = _EmployeeTradeCenters;
            EmployeeTCommoditys = _EmployeeTCommoditys;
            EmployeeSTCommoditys = _EmployeeSTCommoditys;
            EmployeeMTCommoditys = _EmployeeMTCommoditys;
            EmployeeETCommoditys = _EmployeeETCommoditys;
        }
        public ITable<EmployeeTradeCenter> EmployeeTradeCenters {get; private set;}
        public ITable<EmployeeTCommodity> EmployeeTCommoditys {get; private set;}
        public ITable<EmployeeSTCommodity> EmployeeSTCommoditys {get; private set;}
        public ITable<EmployeeMTCommodity> EmployeeMTCommoditys {get; private set;}
        public ITable<EmployeeETCommodity> EmployeeETCommoditys {get; private set;}
    }
}