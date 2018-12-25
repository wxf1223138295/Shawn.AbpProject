using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;
using Shawn.AbpProject.Domain.Test1;
using Shawn.AbpProject.EntityFrameworkCore.Repositories;

namespace Shawn.AbpProject.EntityFrameworkCore.Test2UnitWorkRepository
{
    public class UnitWork1Repository : AbpProjectRepositoryBase<UnitWork1>, IUnitWork1Repository
    {
        public UnitWork1Repository(IDbContextProvider<AbpProjectDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
