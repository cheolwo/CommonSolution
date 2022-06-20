using System;
using System.Threading.Tasks;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofDataAccessLayer.ofOrder.ofDbContext;
using BusinessData.ofDataAccessLayer.ofOrder.ofInterface.ofEmployee;
using BusinessData.ofDataAccessLayer.ofOrder.ofInterface.ofEmployer;
using BusinessData.ofDataAccessLayer.ofOrder.ofInterface.ofPlatform;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;

namespace BusinessData.ofDataAccessLayer.ofOrder.ofRepository
{
    public interface IOrderCenterRepository : ICenterDataRepository<OrderCenter>
    {
        Task<OrderCenter> GetRelatedData(OrderCenter OrderCenter);
    }
    public interface IOCommodityRepository : ICommodityDataRepository<OCommodity>
    {
    }
    public interface ISOCommodityRepository : IStatusDataRepository<SOCommodity>
    {

    }
    public interface IMOCommodityRepository : IStatusDataRepository<MOCommodity>
    {

    }
    public interface IEOCommodityRepository : IStatusDataRepository<EOCommodity>
    {

    }
    public class OrderCenterRepository : CenterDataRepository<OrderCenter>, IOrderCenterRepository, IEmployeeOrderCenterRepository, IEmployerOrderCenterRepository, IPlatformOrderCenterRepository
    {
        public OrderCenterRepository(OrderDbContext orderDbContext)
            :base(orderDbContext)
        {

        }
        public OrderCenterRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }

        public Task<OrderCenter> GetRelatedData(OrderCenter OrderCenter)
        {
            throw new System.NotImplementedException();
        }
    }
    public class OCommodityRepository : CommodityDataRepository<OCommodity>, IOCommodityRepository, IEmployeeOCommodityRepository, IEmployerOCommodityRepository, IPlatformOCommodityRepository
    {
        public OCommodityRepository(OrderDbContext orderDbContext)
            :base(orderDbContext)
        {

        }
        public OCommodityRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
    public class SOCommodityRepository : StatusDataRepository<SOCommodity>, ISOCommodityRepository, IEmployeeSOCommodityRepository, IEmployerSOCommodityRepository, IPlatformSOCommodityRepository
    {
        public SOCommodityRepository(OrderDbContext orderDbContext)
            :base(orderDbContext)
        {

        }
        public SOCommodityRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
    public class MOCommodityRepository : StatusDataRepository<MOCommodity>, IMOCommodityRepository, IEmployeeMOCommodityRepository, IEmployerMOCommodityRepository, IPlatformMOCommodityRepository
    {
        public MOCommodityRepository(OrderDbContext orderDbContext)
            :base(orderDbContext)
        {

        }
        public MOCommodityRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
    public class EOCommodityRepository : StatusDataRepository<EOCommodity>, IEOCommodityRepository, IEmployeeEOCommodityRepository, IEmployerEOCommodityRepository, IPlatformEOCommodityRepository
    {
        public EOCommodityRepository(OrderDbContext orderDbContext)
            :base(orderDbContext)
        {

        }
        public EOCommodityRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
}
