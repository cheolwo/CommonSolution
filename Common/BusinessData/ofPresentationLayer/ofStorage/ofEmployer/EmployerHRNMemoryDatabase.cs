using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployer;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployer
{
    public class EmployerHRNMemoryDatabase : Database
    {
        public EmployerHRNMemoryDatabase()
        {
            var _EmployerHRCenters = this.Tables.Create<EmployerHRCenter, string>(x=>x.Id, null);
            var _EmployerHRBusinessParts = this.Tables.Create<EmployerHRBusinessPart, string>(x=>x.Id, null);
            var _EmployerHREmployees = this.Tables.Create<EmployerHREmployee, string>(x=>x.Id, null);
            var _EmployerHRRoles = this.Tables.Create<EmployerHRRole, string>(x=>x.Id, null);
            var _EmployerEmployeeRoles = this.Tables.Create<EmployerEmployeeRole, string>(x=>x.Id, null);

            EmployerHRCenters = _EmployerHRCenters;
            EmployerHRBusinessParts = _EmployerHRBusinessParts;
            EmployerHREmployees = _EmployerHREmployees;
            EmployerHRRoles = _EmployerHRRoles;
            EmployerEmployeeRoles = _EmployerEmployeeRoles;
        }
        public ITable<EmployerEmployeeRole> EmployerEmployeeRoles {get; private set;}
        public ITable<EmployerHRCenter> EmployerHRCenters {get; private set;}
        public ITable<EmployerHRRole> EmployerHRRoles {get; private set;}
        public ITable<EmployerHRBusinessPart> EmployerHRBusinessParts {get; private set;}
        public ITable<EmployerHREmployee> EmployerHREmployees {get; private set;}
    }
}