using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofPlatform;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofPlatform
{
    public class PlatformWarehouseNMemoryDatabase : Database
    {
        public PlatformWarehouseNMemoryDatabase()
        {
            var _PlatformWarehouses = this.Tables.Create<PlatformWarehouse, string>(x=>x.Id, null);
            var _PlatformWCommoditys = this.Tables.Create<PlatformWCommodity, string>(x=>x.Id, null);
            var _PlatformSWCommoditys = this.Tables.Create<PlatformSWCommodity, string>(x=>x.Id, null);
            var _PlatformMWCommoditys = this.Tables.Create<PlatformMWCommodity, string>(x=>x.Id, null);
            var _PlatformEWCommoditys = this.Tables.Create<PlatformEWCommodity, string>(x=>x.Id, null);
            var _PlatformWorkingDesks = this.Tables.Create<PlatformWorkingDesk, string>(x=>x.Id, null);
            var _PlatformLoadFrames = this.Tables.Create<PlatformLoadFrame, string>(x=>x.Id, null);
            var _PlatformDividedTags = this.Tables.Create<PlatformDividedTag, string>(x=>x.Id, null);
            var _PlatformDotBarcodes = this.Tables.Create<PlatformDotBarcode, string>(x=>x.Id, null);
            var _PlatformIncomingTags = this.Tables.Create<PlatformIncomingTag, string>(x=>x.Id, null);

            PlatformWarehouses = _PlatformWarehouses;
            PlatformWCommoditys = _PlatformWCommoditys;
            PlatformSWCommoditys = _PlatformSWCommoditys;
            PlatformMWCommoditys = _PlatformMWCommoditys;
            PlatformEWCommoditys = _PlatformEWCommoditys;
            PlatformWorkingDesks = _PlatformWorkingDesks;
            PlatformLoadFrames = _PlatformLoadFrames;
            PlatformDividedTags = _PlatformDividedTags;
            PlatformDotBarcodes = _PlatformDotBarcodes;
            PlatformIncomingTags = _PlatformIncomingTags;
        }
        public ITable<PlatformIncomingTag> PlatformIncomingTags {get; private set;}
        public ITable<PlatformDotBarcode> PlatformDotBarcodes {get; private set;}
        public ITable<PlatformDividedTag> PlatformDividedTags {get; private set;}
        public ITable<PlatformLoadFrame> PlatformLoadFrames {get; private set;}
        public ITable<PlatformWorkingDesk> PlatformWorkingDesks {get; private set;}
        public ITable<PlatformWarehouse> PlatformWarehouses {get; private set;}
        public ITable<PlatformWCommodity> PlatformWCommoditys {get; private set;}
        public ITable<PlatformSWCommodity> PlatformSWCommoditys {get; private set;}
        public ITable<PlatformMWCommodity> PlatformMWCommoditys {get; private set;}
        public ITable<PlatformEWCommodity> PlatformEWCommoditys {get; private set;}
    }
}