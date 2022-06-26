using BusinessData.ofDataContext;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness
{
    /// <summary>
    /// 예정
    /// </summary>
    public class DeliveryDataContext : DataContext
    {
        public DeliveryDataContext(DataContextOptions dataContextOptions)
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
            throw new NotImplementedException();
        }

        protected override void OnConfigureEntityRepository(EntityManagerBuilder entityManagerBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
