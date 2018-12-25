using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BizMasterData.Domain;
using Shawn.AbpProject;

namespace BizMasterData.Application
{
    public class TestPluginAppService:AbpProjectAppServiceBase, ITestPluginAppService
    {
        private readonly IPersonRepository _iPersonRepository;

        public TestPluginAppService(IPersonRepository iPersonRepository)
        {
            _iPersonRepository = iPersonRepository;
        }
        public async Task<bool> insertEntityAsync()
        {
           Person p=new Person();
            p.Age = "2";
            p.Name = "4";
            p.Tel = "5";
            var temp = await _iPersonRepository.InsertAsync(p);
            return true;
        }
    }
}
