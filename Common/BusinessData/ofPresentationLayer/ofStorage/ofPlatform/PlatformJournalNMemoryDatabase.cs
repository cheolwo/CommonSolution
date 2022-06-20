using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofPlatform;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofPlatform
{
    public class PlatformJournalNMemoryDatabase : Database
    {
        public PlatformJournalNMemoryDatabase()
        {
            var _PlatformJournalCenters = this.Tables.Create<PlatformJournalCenter, string>(x=>x.Id, null);
            var _PlatformJCommoditys = this.Tables.Create<PlatformJCommodity, string>(x=>x.Id, null);
            var _PlatformJournals = this.Tables.Create<PlatformJournal, string>(x=>x.Id, null);
            PlatformJournalCenters = _PlatformJournalCenters;
            PlatformJCommoditys = _PlatformJCommoditys;
            PlatformJournals = _PlatformJournals;
        }
        public ITable<PlatformJournalCenter> PlatformJournalCenters {get; private set;}
        public ITable<PlatformJCommodity> PlatformJCommoditys {get; private set;}
        public ITable<PlatformJournal> PlatformJournals {get; private set;}
    }
}