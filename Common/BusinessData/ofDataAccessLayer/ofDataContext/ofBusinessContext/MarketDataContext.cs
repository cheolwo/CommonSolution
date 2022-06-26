using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofDataAccessLayer.ofMarket.ofRepository;
using BusinessData.ofDataContext;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness
{
    public class MarketDataContext : DataContext
    {
        public MarketDataContext(DataContextOptions dataContextOptions)
            :base(dataContextOptions)
        {
        }

        public override Task DeleteByIdAsync<T>(string id)
        {
            throw new NotImplementedException();
        }

        public override Task<T> GetByIdAsync<T>(string id)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<T>> GetsAsync<T>()
        {
            throw new NotImplementedException();
        }

        public override Task<T> PostAsync<T>(T t)
        {
            throw new NotImplementedException();
        }

        public override Task<T> PutAsync<T>(T t)
        {
            throw new NotImplementedException();
        }

        protected override void OnConfigureEntityBlobStorage(EntityManagerBuilder entityManagerBuilder)
        {
            throw new NotImplementedException();
        }

        protected override void OnConfigureEntityFile(EntityManagerBuilder entityManagerBuilder)
        {
            throw new NotImplementedException();
        }

        protected override void OnConfigureEntityId(EntityManagerBuilder entityManagerBuilder)
        {
            entityManagerBuilder.ApplyEntityIdFactory(nameof(Market), new EntityIdFactory<Market>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(MCommodity), new EntityIdFactory<MCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(SMCommodity), new EntityIdFactory<SMCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(MMCommodity), new EntityIdFactory<MMCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(EMCommodity), new EntityIdFactory<EMCommodity>());
        }

        protected override void OnConfigureEntityRepository(EntityManagerBuilder entityManagerBuilder)
        {
            entityManagerBuilder.ApplyEntityDataRepository(nameof(Market), new MarketRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(MCommodity), new MCommodityRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(SMCommodity), new SMCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(MMCommodity), new MMCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(EMCommodity), new EMCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
        }
    }
}
