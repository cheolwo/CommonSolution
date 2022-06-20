// using BusinessData.ofHRMarket.ofDbContext;
// using BusinessData.ofHRMarket.ofModel;

// namespace BusinessData.ofHRMarket.ofRepository
// {
//     public interface IHRMarketRepository : ICenterDataRepository<HRMarket>
//     {
//     }

//     public class HRMarketRepository : CenterDataRepository<HRMarket>, IHRMarketRepository
//     {
//         public HRMarketRepository(IHRMarketIdFactory hRMarketIdFactory, HRMarketDbContext hRMarketDbContext)
//             :base(hRMarketIdFactory, hRMarketDbContext)
//         {
//         }
//     }

//     public interface IJobOfferRepository : IEntityDataRepository<JobOffer>
//     {
//     }

//     public class JobOfferRepository : EntityDataRepository<JobOffer>, IJobOfferRepository
//     {
//         public JobOfferRepository(HRMarketDbContext HRMarketDbContext)
//             : base(HRMarketDbContext)
//         {
//         }
//     }
//     public interface IEmployeeMessageRepository : IEntityDataRepository<EmployeeMessage>
//     {
//     }
    
//     public class EmployeeMessageRepository : EntityDataRepository<EmployeeMessage>, IEmployeeMessageRepository
//     {
//         public EmployeeMessageRepository(HRMarketDbContext HRMarketDbContext)
//             : base(HRMarketDbContext)
//         {
//         }
//     }
// }
