﻿using BusinessData.ofDataContext;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness
{
    public class TradeDataContext : DataContext
    {
        public TradeDataContext(IServiceScopeFactory serviceScopeFactory)
            : base(serviceScopeFactory)
        {
        }
        protected override void OnEntityBlobStorageBuilder(EntityManagerBuilder entityManagerBuilder)
        {
            throw new NotImplementedException();
        }

        protected override void OnEntityExcelBuilder(EntityManagerBuilder entityManagerBuilder)
        {
            throw new NotImplementedException();
        }

        protected override void OnEntityIdBuilder(EntityManagerBuilder entityManagerBuilder)
        {
            throw new NotImplementedException();
        }

        protected override void OnEntityPDFBuilder(EntityManagerBuilder entityManagerBuilder)
        {
            throw new NotImplementedException();
        }

        protected override void OnEntityRepositoryBuilder(EntityManagerBuilder entityManagerBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
