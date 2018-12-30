using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Events.Bus;
using AutoMapper;
using Shawn.AbpProject.CenterCost;
using Shawn.AbpProject.Domain.Test1;
using Shawn.AbpProject.Domain.Test2;

namespace Shawn.AbpProject.Server
{
    public class TestUnitWorkAppService: AbpProjectAppServiceBase, ITestUnitWorkAppService
    {
        private readonly IUnitWork1Repository _TestUnitWork1Repository;
        private readonly IUnitWork2Repository _TestUnitWork2Repository;
        private readonly IMapper _mapper;

        public IEventBus EventBus { get; set; }


        public TestUnitWorkAppService(IUnitWork1Repository TestUnit1WorkRepository, IUnitWork2Repository TestUnit2WorkRepository, IMapper mapper, IEventBus eventBus)
        {
            _TestUnitWork1Repository = TestUnit1WorkRepository;
            _TestUnitWork2Repository = TestUnit2WorkRepository;
            _mapper = mapper;
            EventBus = eventBus;
        }


        public async Task TestUnitWork()
        {
            
            UnitWork1 entity1=new UnitWork1();
            entity1.test1 = "1";
            entity1.test2 = "1";
            entity1.test3 = "1";
            await _TestUnitWork1Repository.InsertAsync(entity1);



            UnitWork2 entity2 = new UnitWork2();
            entity2.Id = 1;
            entity2.workTest1 = "11";
            entity2.workTest2 = "11";
            entity2.workTest3 = "11";
            await _TestUnitWork2Repository.InsertAsync(entity2);
        }
    }
}
