using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder.ofEmployee;
using NMemory;
using NMemory.Tables;

namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployee
{
    public class EmployeeGroupOrderNMemoryDatabase : Database
    {
        public EmployeeGroupOrderNMemoryDatabase()
        {
            var _EmployeeGOCS = this.Tables.Create<EmployeeGOC, string>(x => x.Id, null);
            var _EmployeeGOCCS = this.Tables.Create<EmployeeGOCC, string>(x => x.Id, null);
            var _EmployeeSGOCS = this.Tables.Create<EmployeeSGOC, string>(x => x.Id, null);
            var _EmployeeMGOCS = this.Tables.Create<EmployeeMGOC, string>(x => x.Id, null);
            var _EmployeeEGOCS = this.Tables.Create<EmployeeEGOC, string>(x => x.Id, null);

            EmployeeGOCS = _EmployeeGOCS;
            EmployeeGOCCS = _EmployeeGOCCS;
            EmployeeSGOCS = _EmployeeSGOCS;
            EmployeeMGOCS = _EmployeeMGOCS;
            EmployeeEGOCS = _EmployeeEGOCS;
        }
        public ITable<EmployeeGOC> EmployeeGOCS {get; private set;}
        public ITable<EmployeeGOCC> EmployeeGOCCS {get; private set;}
        public ITable<EmployeeSGOC> EmployeeSGOCS {get; private set;}
        public ITable<EmployeeMGOC> EmployeeMGOCS {get; private set;}
        public ITable<EmployeeEGOC> EmployeeEGOCS {get; private set;}
    }
}