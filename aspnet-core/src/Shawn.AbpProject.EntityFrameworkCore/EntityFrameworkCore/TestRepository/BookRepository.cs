using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFrameworkCore;
using Shawn.AbpProject.EntityFrameworkCore.Repositories;
using Shawn.AbpProject.TestEntity;

namespace Shawn.AbpProject.EntityFrameworkCore.TestRepository
{
    public class BookRepository:AbpProjectRepositoryBase<Book>,IBookRepository
    {
        public BookRepository(IDbContextProvider<AbpProjectDbContext> dbContextProvider) : base(dbContextProvider)
        {
            
        }

        public async Task<bool> insertentityTask(Book entity)
        {
            var result =await Context.Books.AddAsync(entity);
            var t =await Context.SaveChangesAsync();
            if (t > 0) return true;
            else
            {
                return false;
            }
        }
    }
}
