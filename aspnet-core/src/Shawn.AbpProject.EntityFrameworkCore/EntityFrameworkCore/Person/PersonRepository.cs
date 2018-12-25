using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;
using BizMasterData.Domain;
using Shawn.AbpProject.CenterPool;
using Shawn.AbpProject.EntityFrameworkCore.Repositories;

namespace Shawn.AbpProject.EntityFrameworkCore.Person
{
    public class PersonRepository:AbpProjectRepositoryBase<BizMasterData.Domain.Person>, IPersonRepository
    {
        public PersonRepository(IDbContextProvider<AbpProjectDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

    }
}
