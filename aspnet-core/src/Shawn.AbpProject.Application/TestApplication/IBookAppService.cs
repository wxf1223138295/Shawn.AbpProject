using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Shawn.AbpProject.TestApplication.Dto;
using Shawn.AbpProject.TestEntity;

namespace Shawn.AbpProject.TestApplication
{
    public interface IBookAppService
    {
        Task<bool> insertEntityAsync(BookDto input);
        Task<Book> GetEntityAsync(int id);
    }
}
