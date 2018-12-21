using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using AutoMapper;
using Shawn.AbpProject.TestApplication.Dto;
using Shawn.AbpProject.TestEntity;

namespace Shawn.AbpProject.TestApplication
{
    public class BookAppService:AbpProjectAppServiceBase, IBookAppService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookAppService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<bool> insertEntityAsync(BookDto input)
        {
            var kb=ObjectMapper.Map<Book>(input);
            var b = input.MapTo<Book>();
            //Book b=new Book
            //{
            //    BookName = "F#",
            //    BookPublish = DateTime.Now,
            //    pricebook = 40,
            //    publisher = "sa"
            //};
            var temp=await _bookRepository.insertentityTask(b);

            return temp;
        }

        public async Task<Book> GetEntityAsync(int id)
        {
            var result = await _bookRepository.GetAsync(id);
            return result;
        }
    }
}
