using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployee;
using NMemory;
using NMemory.Tables;

namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployee
{
    public class EmployeeHRNMemoryDatabase : Database
    {
        public EmployeeHRNMemoryDatabase()
        {
            var _EmployeeHRCenters = this.Tables.Create<EmployeeHRCenter, string>(x=>x.Id, null);
            var _EmployeeHRBusinessParts = this.Tables.Create<EmployeeHRBusinessPart, string>(x=>x.Id, null);
            var _EmployeeHREmployees = this.Tables.Create<EmployeeHREmployee, string>(x=>x.Id, null);
            var _EmployeeHRRoles = this.Tables.Create<EmployeeHRRole, string>(x=>x.Id, null);
            var _EmployeeEmployeeRoles = this.Tables.Create<EmployeeEmployeeRole, string>(x=>x.Id, null);
            
            EmployeeHRCenters = _EmployeeHRCenters;
            EmployeeHRBusinessParts = _EmployeeHRBusinessParts;
            EmployeeHREmployees = _EmployeeHREmployees;
            EmployeeHRRoles = _EmployeeHRRoles;
            EmployeeEmployeeRoles = _EmployeeEmployeeRoles;
        }
        public ITable<EmployeeEmployeeRole> EmployeeEmployeeRoles {get; private set;}
        public ITable<EmployeeHRCenter> EmployeeHRCenters {get; private set;}
        public ITable<EmployeeHRRole> EmployeeHRRoles {get; private set;}
        public ITable<EmployeeHRBusinessPart> EmployeeHRBusinessParts {get; private set;}
        public ITable<EmployeeHREmployee> EmployeeHREmployees {get; private set;}
    }
}