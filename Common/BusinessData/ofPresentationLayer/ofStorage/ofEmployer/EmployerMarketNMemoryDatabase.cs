using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployer;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployer
{
    public class EmployerMarketNMemoryDatabase : Database
    {
        public EmployerMarketNMemoryDatabase()
        {
            var _EmployerMarkets = this.Tables.Create<EmployerMarket, string>(x=>x.Id, null);
            var _EmployerPlatMarkets = this.Tables.Create<EmployerPlatMarket, string>(x=>x.Id, null);
            var _EmployerMCommoditys = this.Tables.Create<EmployerMCommodity, string>(x=>x.Id, null);
            var _EmployerSMCommoditys = this.Tables.Create<EmployerSMCommodity, string>(x=>x.Id, null);
            var _EmployerMMCommoditys = this.Tables.Create<EmployerMMCommodity, string>(x=>x.Id, null);
            var _EmployerEMCommoditys = this.Tables.Create<EmployerEMCommodity, string>(x=>x.Id, null);

            EmployerMarkets = _EmployerMarkets;
            EmployerPlatMarkets = _EmployerPlatMarkets;
            EmployerMCommoditys = _EmployerMCommoditys;
            EmployerMMCommoditys = _EmployerMMCommoditys;
            EmployerSMCommoditys = _EmployerSMCommoditys;
            EmployerEMCommoditys = _EmployerEMCommoditys;
        }
        public ITable<EmployerMarket> EmployerMarkets {get; private set;}
        public ITable<EmployerPlatMarket> EmployerPlatMarkets {get; private set;}
        public ITable<EmployerMCommodity> EmployerMCommoditys {get; private set;}
        public ITable<EmployerSMCommodity> EmployerSMCommoditys {get; private set;}
        public ITable<EmployerMMCommodity> EmployerMMCommoditys {get; private set;}
        public ITable<EmployerEMCommodity> EmployerEMCommoditys {get; private set;}
    }
}