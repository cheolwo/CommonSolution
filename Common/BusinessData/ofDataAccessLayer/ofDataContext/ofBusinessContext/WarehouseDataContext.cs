using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofRepository;
using BusinessData.ofDataContext;
using BusinessLogic.ofEntityManager.ofWarehouse.ofIdFactory;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness
{
    public class WarehouseDataContext : DataContext
    {
        public WarehouseDataContext(DataContextOptions dataContextOptions)
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
            entityManagerBuilder.ApplyEntityIdFactory(nameof(Warehouse), new WarehouseIdFactory());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(WCommodity), new EntityIdFactory<WCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(SWCommodity), new EntityIdFactory<SWCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(MWCommodity), new EntityIdFactory<MWCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(EWCommodity), new EntityIdFactory<EWCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(DividedTag), new EntityIdFactory<DividedTag>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(IncomingTag), new EntityIdFactory<IncomingTag>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(LoadFrame), new EntityIdFactory<LoadFrame>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(WorkingDesk), new EntityIdFactory<WorkingDesk>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(DotBarcode), new EntityIdFactory<DotBarcode>());
        }

        protected override void OnConfigureEntityRepository(EntityManagerBuilder entityManagerBuilder)
        {
            entityManagerBuilder.ApplyEntityDataRepository(nameof(Warehouse), new WarehouseRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(WCommodity), new WCommodityRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(SWCommodity), new SWCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(MWCommodity), new MWCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(EWCommodity), new EWCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(LoadFrame), new LoadFrameRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(DividedTag), new DividedTagRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(IncomingTag), new IncomingTagRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(DotBarcode), new DotBarcodeRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(WorkingDesk), new WorkingDeskRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
        }
    }
}
