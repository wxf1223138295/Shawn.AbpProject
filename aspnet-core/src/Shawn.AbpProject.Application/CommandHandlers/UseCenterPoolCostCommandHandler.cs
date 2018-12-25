using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFrameworkCore.Repositories;
using Abp.Events.Bus.Handlers;
using Shawn.AbpProject.CenterPool;
using Shawn.AbpProject.Commands;
using Shawn.AbpProject.Enum;

namespace Shawn.AbpProject.CommandHandlers
{
    public class UseCenterPoolCostCommandHandler : IAsyncEventHandler<UseCenterPoolCostCommand>
    {
        private readonly ICenterCostRepository _orderRepository;
        public async Task HandleEventAsync(UseCenterPoolCostCommand eventData)
        {
            var entity=new CenterPool.CenterCost("2018",10000);

            entity.UseCenterCost(1);

            await _orderRepository.InsertAsync(entity);

            await _orderRepository.GetDbContext().SaveChangesAsync();
        }
    }
}
