using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;
using Shawn.AbpProject.ApplyPool;
using Shawn.AbpProject.CenterPool;
using Shawn.AbpProject.EntityFrameworkCore.Repositories;

namespace Shawn.AbpProject.EntityFrameworkCore.ApplyCostPool
{
    public class ApplyPoolRepository: AbpProjectRepositoryBase<ApplyCost>, IApplyPoolRepository
    {
        public ApplyPoolRepository(IDbContextProvider<AbpProjectDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
