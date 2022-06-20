using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofDataContext;
using BusinessData.ofProduct.ofRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness
{
    public class ProductDataContext : DataContext
    {
        public ProductDataContext(DataContextOptions dataContextOptions)
            : base(dataContextOptions)
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
            entityManagerBuilder.ApplyEntityIdFactory(nameof(ProductCenter), new EntityIdFactory<ProductCenter>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(PCommodity), new EntityIdFactory<PCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(SPCommodity), new EntityIdFactory<SPCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(MPCommodity), new EntityIdFactory<MPCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(EPCommodity), new EntityIdFactory<EPCommodity>());
        }

        protected override void OnConfigureEntityRepository(EntityManagerBuilder entityManagerBuilder)
        {
            entityManagerBuilder.ApplyEntityDataRepository(nameof(ProductCenter), new ProductCenterRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(PCommodity), new PCommodityRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(SPCommodity), new SPCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(MPCommodity), new MPCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(EPCommodity), new EPCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            //entityManagerBuilder.ApplyEntityDataRepository(nameof(Producter), new ProducterRepository(e =>
            //{
            //    e.UsingDistributedCache = true;
            //    e.UsingMemoryCache = true;
            //    e.UsedSingleton = true;
            //}));
            //entityManagerBuilder.ApplyEntityDataRepository(nameof(ProductLand), new ProductLandRepository(e =>
            //{
            //    e.UsingDistributedCache = true;
            //    e.UsingMemoryCache = true;
            //    e.UsedSingleton = true;
            //}));
        }
    }
}
