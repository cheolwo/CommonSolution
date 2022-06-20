using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofPlatform;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofPlatform
{
    public class PlatformMarketNMemoryDatabase : Database
    {
        public PlatformMarketNMemoryDatabase()
        {
            var _PlatformMarkets = this.Tables.Create<PlatformMarket, string>(x=>x.Id, null);
            var _PlatformPlatMarkets = this.Tables.Create<PlatformPlatMarket, string>(x=>x.Id, null);
            var _PlatformMCommoditys = this.Tables.Create<PlatformMCommodity, string>(x=>x.Id, null);
            var _PlatformSMCommoditys = this.Tables.Create<PlatformSMCommodity, string>(x=>x.Id, null);
            var _PlatformMMCommoditys = this.Tables.Create<PlatformMMCommodity, string>(x=>x.Id, null);
            var _PlatformEMCommoditys = this.Tables.Create<PlatformEMCommodity, string>(x=>x.Id, null);
            PlatformMarkets = _PlatformMarkets;
            PlatformPlatMarkets = _PlatformPlatMarkets;
            PlatformMCommoditys = _PlatformMCommoditys;
            PlatformMMCommoditys = _PlatformMMCommoditys;
            PlatformSMCommoditys = _PlatformSMCommoditys;
            PlatformEMCommoditys = _PlatformEMCommoditys;
        }
        public ITable<PlatformMarket> PlatformMarkets {get; private set;}
        public ITable<PlatformPlatMarket> PlatformPlatMarkets {get; private set;}
        public ITable<PlatformMCommodity> PlatformMCommoditys {get; private set;}
        public ITable<PlatformSMCommodity> PlatformSMCommoditys {get; private set;}
        public ITable<PlatformMMCommodity> PlatformMMCommoditys {get; private set;}
        public ITable<PlatformEMCommodity> PlatformEMCommoditys {get; private set;}
    }
}