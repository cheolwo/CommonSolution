using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofDataAccessLayer.ofMarket.ofDbContext;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using System;

namespace BusinessData.ofDataAccessLayer.ofMarket.ofRepository
{
    public interface IMarketRepository : ICenterDataRepository<Market>
    {

    }
    public interface IMCommodityRepository : ICommodityDataRepository<MCommodity>
    {

    }
    public interface ISMCommodityRepository : IStatusDataRepository<SMCommodity>
    {

    }
    public interface IMMCommodityRepository : IStatusDataRepository<MMCommodity>
    {

    }
    public interface IEMCommodityRepository : IStatusDataRepository<EMCommodity>
    {

    }
    public interface IPlatMarketRepository : ICenterDataRepository<PlatMarket>
    {

    }
    public class MarketRepository : CenterDataRepository<Market>, IMarketRepository
    {
        public MarketRepository(MarketDbContext MarketDbContext)
                : base(MarketDbContext)
        {

        }
        public MarketRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
    public class MCommodityRepository : CommodityDataRepository<MCommodity>, IMCommodityRepository
    {
        public MCommodityRepository(MarketDbContext MarketDbContext)
                : base(MarketDbContext)
        {

        }
        public MCommodityRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
    public class SMCommodityRepository : StatusDataRepository<SMCommodity>, ISMCommodityRepository
    {
        public SMCommodityRepository(MarketDbContext MarketDbContext)
                : base(MarketDbContext)
        {

        }
        public SMCommodityRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
    public class MMCommodityRepository : StatusDataRepository<MMCommodity>, IMMCommodityRepository
    {
        public MMCommodityRepository(MarketDbContext MarketDbContext)
                : base(MarketDbContext)
        {

        }
        public MMCommodityRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
    public class EMCommodityRepository : StatusDataRepository<EMCommodity>, IEMCommodityRepository
    {
        public EMCommodityRepository(MarketDbContext MarketDbContext)
                : base(MarketDbContext)
        {

        }
        public EMCommodityRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
}