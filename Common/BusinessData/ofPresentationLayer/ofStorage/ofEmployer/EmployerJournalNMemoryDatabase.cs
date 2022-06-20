using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployer;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployer
{
    public class EmployerJournalNMemoryDatabase : Database
    {
        public EmployerJournalNMemoryDatabase()
        {
            var _EmployerJournalCenters = this.Tables.Create<EmployerJournalCenter, string>(x=>x.Id, null);
            var _EmployerJCommoditys = this.Tables.Create<EmployerJCommodity, string>(x=>x.Id, null);
            var _EmployerJournals = this.Tables.Create<EmployerJournal, string>(x=>x.Id, null);

            EmployerJournalCenters = _EmployerJournalCenters;
            EmployerJCommoditys = _EmployerJCommoditys;
            EmployerJournals = _EmployerJournals;
        }
        public ITable<EmployerJournalCenter> EmployerJournalCenters {get; private set;}
        public ITable<EmployerJCommodity> EmployerJCommoditys {get; private set;}
        public ITable<EmployerJournal> EmployerJournals {get; private set;}
    }
}