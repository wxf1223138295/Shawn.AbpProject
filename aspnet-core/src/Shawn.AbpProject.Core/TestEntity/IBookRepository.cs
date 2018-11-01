using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;

namespace Shawn.AbpProject.TestEntity
{
    public interface IBookRepository:IRepository<Book>
    {
        Task<bool> insertentityTask(Book entity);
    }
}
