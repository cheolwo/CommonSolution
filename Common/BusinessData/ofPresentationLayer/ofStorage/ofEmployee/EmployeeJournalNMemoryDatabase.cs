using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployee;
using NMemory;
using NMemory.Tables;

namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployee
{
    public class EmployeeJournalNMemoryDatabase : Database
    {
        public EmployeeJournalNMemoryDatabase()
        {
            var _EmployeeJournalCenters = this.Tables.Create<EmployeeJournalCenter, string>(x=>x.Id, null);
            var _EmployeeJCommoditys = this.Tables.Create<EmployeeJCommodity, string>(x=>x.Id, null);
            var _EmployeeJournals = this.Tables.Create<EmployeeJournal, string>(x=>x.Id, null);
            EmployeeJournalCenters = _EmployeeJournalCenters;
            EmployeeJCommoditys = _EmployeeJCommoditys;
            EmployeeJournals = _EmployeeJournals;
        }
        public ITable<EmployeeJournalCenter> EmployeeJournalCenters {get; private set;}
        public ITable<EmployeeJCommodity> EmployeeJCommoditys {get; private set;}
        public ITable<EmployeeJournal> EmployeeJournals {get; private set;}
    }
}