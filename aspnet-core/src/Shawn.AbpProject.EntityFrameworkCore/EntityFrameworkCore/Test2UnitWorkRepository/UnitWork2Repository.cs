using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;
using Shawn.AbpProject.Domain.Test2;
using Shawn.AbpProject.EntityFrameworkCore.Repositories;

namespace Shawn.AbpProject.EntityFrameworkCore.Test2UnitWorkRepository
{
    public class UnitWork2Repository :  AbpProjectRepositoryBase<UnitWork2>, IUnitWork2Repository
    {
        public UnitWork2Repository(IDbContextProvider<AbpProjectDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
