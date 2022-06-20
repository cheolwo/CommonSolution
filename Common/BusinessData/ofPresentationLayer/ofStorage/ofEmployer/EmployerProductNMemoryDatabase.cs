using BusinessData.ofPresentationLayer.ofDTO.ofProduct.ofEmployer;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployer
{
    public class EmployerProductNMemoryDatabase : Database
    {
        public EmployerProductNMemoryDatabase()
        {
            var _EmployerProductCenters = this.Tables.Create<EmployerProductCenter, string>(x=>x.Id, null);
            var _EmployerPCommoditys = this.Tables.Create<EmployerPCommodity, string>(x=>x.Id, null);
            var _EmployerSPCommoditys = this.Tables.Create<EmployerSPCommodity, string>(x=>x.Id, null);
            var _EmployerMPCommoditys = this.Tables.Create<EmployerMPCommodity, string>(x=>x.Id, null);
            var _EmployerEPCommoditys = this.Tables.Create<EmployerEPCommodity, string>(x=>x.Id, null);
            var _EmployerProductLands = this.Tables.Create<EmployerProductLand, string>(x=>x.Id, null);
            var _EmployerProducters = this.Tables.Create<EmployerProducter, string>(x=>x.Id, null);

            EmployerProductCenters = _EmployerProductCenters;
            EmployerPCommoditys = _EmployerPCommoditys;
            EmployerSPCommoditys= _EmployerSPCommoditys;
            EmployerMPCommoditys = _EmployerMPCommoditys;
            EmployerEPCommoditys = _EmployerEPCommoditys;
            EmployerProductLands = _EmployerProductLands;
            EmployerProducters = _EmployerProducters;
        }
        public ITable<EmployerProductCenter> EmployerProductCenters {get; private set;}
        public ITable<EmployerPCommodity> EmployerPCommoditys {get; private set;}
        public ITable<EmployerSPCommodity> EmployerSPCommoditys {get; private set;}
        public ITable<EmployerMPCommodity> EmployerMPCommoditys {get; private set;}
        public ITable<EmployerEPCommodity> EmployerEPCommoditys {get; private set;}
        public ITable<EmployerProductLand> EmployerProductLands {get; private set;}
        public ITable<EmployerProducter> EmployerProducters {get; private set;}
    }
}