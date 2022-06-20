using BusinessData.ofPresentationLayer.ofDTO.ofTrade.ofPlatform;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofPlatform
{
    public class PlatformTradeNMemoryDatabase : Database
    {
        public PlatformTradeNMemoryDatabase()
        {
            var _PlatformTradeCenters = this.Tables.Create<PlatformTradeCenter, string>(x=>x.Id, null);
            var _PlatformTCommoditys = this.Tables.Create<PlatformTCommodity, string>(x=>x.Id, null);
            var _PlatformSTCommoditys = this.Tables.Create<PlatformSTCommodity, string>(x=>x.Id, null);
            var _PlatformMTCommoditys = this.Tables.Create<PlatformMTCommodity, string>(x=>x.Id, null);
            var _PlatformETCommoditys = this.Tables.Create<PlatformETCommodity, string>(x=>x.Id, null);
            PlatformTradeCenters = _PlatformTradeCenters;
            PlatformTCommoditys = _PlatformTCommoditys;
            PlatformSTCommoditys = _PlatformSTCommoditys;
            PlatformMTCommoditys = _PlatformMTCommoditys;
            PlatformETCommoditys = _PlatformETCommoditys;
        }
        public ITable<PlatformTradeCenter> PlatformTradeCenters {get; private set;}
        public ITable<PlatformTCommodity> PlatformTCommoditys {get; private set;}
        public ITable<PlatformSTCommodity> PlatformSTCommoditys {get; private set;}
        public ITable<PlatformMTCommodity> PlatformMTCommoditys {get; private set;}
        public ITable<PlatformETCommodity> PlatformETCommoditys {get; private set;}
    }
}