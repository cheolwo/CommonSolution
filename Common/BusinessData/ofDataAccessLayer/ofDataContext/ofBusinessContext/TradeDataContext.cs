using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using BusinessData.ofDataAccessLayer.ofTrade.ofRepository;
using BusinessData.ofDataContext;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness
{
    public class TradeDataContext : DataContext
    {
        public TradeDataContext(DataContextOptions dataContextOptions)
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
            entityManagerBuilder.ApplyEntityIdFactory(nameof(TradeCenter), new EntityIdFactory<TradeCenter>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(TCommodity), new EntityIdFactory<TCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(STCommodity), new EntityIdFactory<STCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(MTCommodity), new EntityIdFactory<MTCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(ETCommodity), new EntityIdFactory<ETCommodity>());
        }

        protected override void OnConfigureEntityRepository(EntityManagerBuilder entityManagerBuilder)
        {
            entityManagerBuilder.ApplyEntityDataRepository(nameof(TradeCenter), new TradeCenterRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(TCommodity), new TCommodityRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(STCommodity), new STCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(MTCommodity), new MTCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(ETCommodity), new ETCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
        }
    }
}
