using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofPlatform;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofPlatform
{
    public class PlatformProductNMemoryDatabase : Database
    {
        public PlatformProductNMemoryDatabase()
        {
            var _PlatformProductCenters = this.Tables.Create<PlatformProductCenter, string>(x=>x.Id, null);
            var _PlatformPCommoditys = this.Tables.Create<PlatformPCommodity, string>(x=>x.Id, null);
            var _PlatformSPCommoditys = this.Tables.Create<PlatformSPCommodity, string>(x=>x.Id, null);
            var _PlatformMPCommoditys = this.Tables.Create<PlatformMPCommodity, string>(x=>x.Id, null);
            var _PlatformEPCommoditys = this.Tables.Create<PlatformEPCommodity, string>(x=>x.Id, null);
            var _PlatformProductLands = this.Tables.Create<PlatformProductLand, string>(x=>x.Id, null);
            var _PlatformProducters = this.Tables.Create<PlatformProducter, string>(x=>x.Id, null);
            PlatformProductCenters = _PlatformProductCenters;
            PlatformPCommoditys = _PlatformPCommoditys;
            PlatformSPCommoditys= _PlatformSPCommoditys;
            PlatformMPCommoditys = _PlatformMPCommoditys;
            PlatformEPCommoditys = _PlatformEPCommoditys;
            PlatformProductLands = _PlatformProductLands;
            PlatformProducters = _PlatformProducters;
        }
        public ITable<PlatformProductCenter> PlatformProductCenters {get; private set;}
        public ITable<PlatformPCommodity> PlatformPCommoditys {get; private set;}
        public ITable<PlatformSPCommodity> PlatformSPCommoditys {get; private set;}
        public ITable<PlatformMPCommodity> PlatformMPCommoditys {get; private set;}
        public ITable<PlatformEPCommodity> PlatformEPCommoditys {get; private set;}
        public ITable<PlatformProductLand> PlatformProductLands {get; private set;}
        public ITable<PlatformProducter> PlatformProducters {get; private set;}
    }
}