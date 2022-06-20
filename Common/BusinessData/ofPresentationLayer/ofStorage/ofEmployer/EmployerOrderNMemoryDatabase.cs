using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployer;
using NMemory;
using NMemory.Tables;
namespace BusinessData.ofPresentationLayer.ofStorage.ofEmployer
{
    public class EmployerOrderNMemoryDatabase : Database
    {
        public EmployerOrderNMemoryDatabase()
        {
            var  _EmployerOrderCenters = this.Tables.Create<EmployerOrderCenter, string>(x=>x.Id, null);
            var  _EmployerOCommoditys = this.Tables.Create<EmployerOCommodity, string>(x=>x.Id, null);
            var  _EmployerSOCommoditys = this.Tables.Create<EmployerSOCommodity, string>(x=>x.Id, null);
            var  _EmployerMOCommoditys = this.Tables.Create<EmployerMOCommodity, string>(x=>x.Id, null);
            var _EmployerEOCommoditys = this.Tables.Create<EmployerEOCommodity, string>(x=>x.Id, null);

            EmployerOrderCenters = _EmployerOrderCenters;
            EmployerOCommoditys = _EmployerOCommoditys;
            EmployerSOCommoditys = _EmployerSOCommoditys;
            EmployerMOCommoditys = _EmployerMOCommoditys;
            EmployerEOCommoditys = _EmployerEOCommoditys;
        }
        public ITable<EmployerOrderCenter> EmployerOrderCenters {get; private set;}
        public ITable<EmployerOCommodity> EmployerOCommoditys {get; private set;}
        public ITable<EmployerSOCommodity> EmployerSOCommoditys {get; private set;}
        public ITable<EmployerMOCommodity> EmployerMOCommoditys {get; private set;}
        public ITable<EmployerEOCommodity> EmployerEOCommoditys {get; private set;}
    }
}