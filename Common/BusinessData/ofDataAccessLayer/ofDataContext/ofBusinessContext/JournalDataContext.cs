using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using BusinessData.ofDataAccessLayer.ofJournal.ofRepository;
using BusinessData.ofDataContext;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness
{
    public class JournalDataContext : DataContext
    {
        public JournalDataContext(DataContextOptions dataContextOptions)
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
            entityManagerBuilder.ApplyEntityIdFactory(nameof(JournalCenter), new EntityIdFactory<JournalCenter>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(JCommodity), new EntityIdFactory<JCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(Journal), new EntityIdFactory<Journal>());
        }

        protected override void OnConfigureEntityRepository(EntityManagerBuilder entityManagerBuilder)
        {
            entityManagerBuilder.ApplyEntityDataRepository(nameof(JournalCenter), new JournalCenterRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(Journal), new JournalRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(JCommodity), new JCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
        }
    }
}
