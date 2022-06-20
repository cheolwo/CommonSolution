using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofPlatform;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofPlatform
{
    public class PlatformHRNMemoryDatabase : Database
    {
        public PlatformHRNMemoryDatabase()
        {
            var _PlatformHRCenters = this.Tables.Create<PlatformHRCenter, string>(x=>x.Id, null);
            var _PlatformHRBusinessParts = this.Tables.Create<PlatformHRBusinessPart, string>(x=>x.Id, null);
            var _PlatformHREmployees = this.Tables.Create<PlatformHREmployee, string>(x=>x.Id, null);
            var _PlatformHRRoles = this.Tables.Create<PlatformHRRole, string>(x=>x.Id, null);
            var _PlatformEmployeeRoles = this.Tables.Create<PlatformEmployeeRole, string>(x=>x.Id, null);
            
            PlatformHRCenters = _PlatformHRCenters;
            PlatformHRBusinessParts = _PlatformHRBusinessParts;
            PlatformHREmployees = _PlatformHREmployees;
            PlatformHRRoles = _PlatformHRRoles;
            PlatformEmployeeRoles = _PlatformEmployeeRoles;
        }
        public ITable<PlatformEmployeeRole> PlatformEmployeeRoles {get; private set;}
        public ITable<PlatformHRCenter> PlatformHRCenters {get; private set;}
        public ITable<PlatformHRRole> PlatformHRRoles {get; private set;}
        public ITable<PlatformHRBusinessPart> PlatformHRBusinessParts {get; private set;}
        public ITable<PlatformHREmployee> PlatformHREmployees {get; private set;}
    }
}