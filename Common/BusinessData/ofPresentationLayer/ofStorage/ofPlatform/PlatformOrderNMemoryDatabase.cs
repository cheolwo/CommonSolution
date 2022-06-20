using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofPlatform;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofPlatform
{
    public class PlatformOrderNMemoryDatabase : Database
    {
        public PlatformOrderNMemoryDatabase()
        {
            var _PlatformOrderCenters = this.Tables.Create<PlatformOrderCenter, string>(x=>x.Id, null);
            var _PlatformOCommoditys = this.Tables.Create<PlatformOCommodity, string>(x=>x.Id, null);
            var _PlatformSOCommoditys = this.Tables.Create<PlatformSOCommodity, string>(x=>x.Id, null);
            var _PlatformMOCommoditys = this.Tables.Create<PlatformMOCommodity, string>(x=>x.Id, null);
            var _PlatformEOCommoditys = this.Tables.Create<PlatformEOCommodity, string>(x=>x.Id, null);
            PlatformOrderCenters = _PlatformOrderCenters;
            PlatformOCommoditys = _PlatformOCommoditys;
            PlatformSOCommoditys = _PlatformSOCommoditys;
            PlatformMOCommoditys = _PlatformMOCommoditys;
            PlatformEOCommoditys = _PlatformEOCommoditys;
        }
        public ITable<PlatformOrderCenter> PlatformOrderCenters {get; private set;}
        public ITable<PlatformOCommodity> PlatformOCommoditys {get; private set;}
        public ITable<PlatformSOCommodity> PlatformSOCommoditys {get; private set;}
        public ITable<PlatformMOCommodity> PlatformMOCommoditys {get; private set;}
        public ITable<PlatformEOCommodity> PlatformEOCommoditys {get; private set;}
    }
}