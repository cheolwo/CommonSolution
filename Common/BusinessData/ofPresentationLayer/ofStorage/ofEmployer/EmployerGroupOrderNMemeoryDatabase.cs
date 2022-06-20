using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployer;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployer
{
    public class EmployerGroupOrderNMemoryDatabase : Database
    {
        public EmployerGroupOrderNMemoryDatabase()
        {
            var _EmployerGOCS = this.Tables.Create<EmployerGOC, string>(x => x.Id, null);
            var _EmployerGOCCS = this.Tables.Create<EmployerGOCC, string>(x => x.Id, null);
            var _EmployerSGOCS = this.Tables.Create<EmployerSGOC, string>(x => x.Id, null);
            var _EmployerMGOCS = this.Tables.Create<EmployerMGOC, string>(x => x.Id, null);
            var _EmployerEGOCS = this.Tables.Create<EmployerEGOC, string>(x => x.Id, null);

            EmployerGOCS = _EmployerGOCS;
            EmployerGOCCS = _EmployerGOCCS;
            EmployerSGOCS = _EmployerSGOCS;
            EmployerMGOCS = _EmployerMGOCS;
            EmployerEGOCS = _EmployerEGOCS;
        }
        public ITable<EmployerGOC> EmployerGOCS {get; private set;}
        public ITable<EmployerGOCC> EmployerGOCCS {get; private set;}
        public ITable<EmployerSGOC> EmployerSGOCS {get; private set;}
        public ITable<EmployerMGOC> EmployerMGOCS {get; private set;}
        public ITable<EmployerEGOC> EmployerEGOCS {get; private set;}
    }
}