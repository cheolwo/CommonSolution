using BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofDbContext;
using BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofInterface.ofEmployee;
using BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofInterface.ofEmployer;
using BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofInterface.ofPlatform;
using BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofModel;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofRepository
{
    public interface IDeliveryCenterRepository : ICenterDataRepository<DeliveryCenter>
    {

    }
    public interface IDCommodityRepository : ICommodityDataRepository<DCommodity>
    {

    }
    public interface ISDCommodityRepository : ISStatusDataRepository<SDCommodity>
    {

    }
    public interface IMDCommodityRepository : IMStatusDataRepository<MDCommodity>
    {

    }
    public interface IEDCommodityRepository : IEStatusDataRepository<EDCommodity>
    {

    }
    public class DeliveryCenterRepository : CenterDataRepository<DeliveryCenter>, IDeliveryCenterRepository, IEmployeeDeliveryCenterRepository, IEmployerDeliveryCenterRepository, IPlatformDeliveryCenterRepository
    {
        public DeliveryCenterRepository(DeliveryDbContext DeliveryDbContext)
            :base(DeliveryDbContext)
        {
            
        }
    }
    public class DCommodityRepository : CommodityDataRepository<DCommodity>, IDCommodityRepository, IEmployeeDCommodityRepository, IEmployerDCommodityRepository, IPlatformDCommodityRepository
    {
        public DCommodityRepository(DeliveryDbContext DeliveryDbContext)
                : base(DeliveryDbContext)
        {

        }
    }
    public class SDCommodityRepository : StatusDataRepository<SDCommodity>, ISDCommodityRepository, IEmployeeSDCommodityRepository, IEmployerSDCommodityRepository, IPlatformSDCommodityRepository
    {
        public SDCommodityRepository(DeliveryDbContext DeliveryDbContext)
                : base(DeliveryDbContext)
        {

        }

        public Task<List<SDCommodity>> GetToListWithMStatusesAsync()
        {
            throw new System.NotImplementedException();
        }
    }
    public class MDCommodityRepository : StatusDataRepository<MDCommodity>, IMDCommodityRepository, IEmployeeMDCommodityRepository, IEmployerMDCommodityRepository, IPlatformMDCommodityRepository
    {
        public MDCommodityRepository(DeliveryDbContext DeliveryDbContext)
                : base(DeliveryDbContext)
        {

        }

        public Task<List<MDCommodity>> GetToListWithEStatusesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<MDCommodity>> GetToListWithSStatusAsync()
        {
            throw new System.NotImplementedException();
        }
    }
    public class EDCommodityRepository : StatusDataRepository<EDCommodity>, IEDCommodityRepository, IEmployeeEDCommodityRepository, IEmployerEDCommodityRepository, IPlatformEDCommodityRepository
    {
        public EDCommodityRepository(DeliveryDbContext DeliveryDbContext)
                : base(DeliveryDbContext)
        {

        }
    }
}