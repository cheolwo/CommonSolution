using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofRepository;
using BusinessData.ofDataContext;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness
{
    public class HRDataContext : DataContext
    {
        public HRDataContext(DataContextOptions dataContextOptions)
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
            entityManagerBuilder.ApplyEntityIdFactory(nameof(HRCenter), new EntityIdFactory<HRCenter>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(HREmployee), new EntityIdFactory<HREmployee>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(HRRole), new EntityIdFactory<HRRole>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(HRBusinessPart), new EntityIdFactory<HRBusinessPart>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(EmployeeRole), new EntityIdFactory<EmployeeRole>());
        }

        protected override void OnConfigureEntityRepository(EntityManagerBuilder entityManagerBuilder)
        {
            entityManagerBuilder.ApplyEntityDataRepository(nameof(HRCenter), new WarehouseRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(HREmployee), new WCommodityRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(HRRole), new SWCommodityRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(HRBusinessPart), new MWCommodityRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(EmployeeRole), new EWCommodityRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
        }
    }
}
