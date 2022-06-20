using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofEmployer;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployer
{
    public class EmployerTradeNMemoryDatabase : Database
    {
        public EmployerTradeNMemoryDatabase()
        {
            var _EmployerTradeCenters = this.Tables.Create<EmployerTradeCenter, string>(x=>x.Id, null);
            var _EmployerTCommoditys = this.Tables.Create<EmployerTCommodity, string>(x=>x.Id, null);
            var _EmployerSTCommoditys = this.Tables.Create<EmployerSTCommodity, string>(x=>x.Id, null);
            var _EmployerMTCommoditys = this.Tables.Create<EmployerMTCommodity, string>(x=>x.Id, null);
            var _EmployerETCommoditys = this.Tables.Create<EmployerETCommodity, string>(x=>x.Id, null);
            
            EmployerTradeCenters = _EmployerTradeCenters;
            EmployerTCommoditys = _EmployerTCommoditys;
            EmployerSTCommoditys = _EmployerSTCommoditys;
            EmployerMTCommoditys = _EmployerMTCommoditys;
            EmployerETCommoditys = _EmployerETCommoditys;
        }
        public ITable<EmployerTradeCenter> EmployerTradeCenters {get; private set;}
        public ITable<EmployerTCommodity> EmployerTCommoditys {get; private set;}
        public ITable<EmployerSTCommodity> EmployerSTCommoditys {get; private set;}
        public ITable<EmployerMTCommodity> EmployerMTCommoditys {get; private set;}
        public ITable<EmployerETCommodity> EmployerETCommoditys {get; private set;}
    }
}