using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Shawn.AbpProject.TestApplication.Dto;
using Shawn.AbpProject.TestEntity;

namespace Shawn.AbpProject
{
    internal static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            //自定义映射规则
            //configuration.CreateMap<BookDto, Book>().ForMember(u => u.pricebook, op => op.Ignore())
            //    .ForMember(u => u.BookName, op => op.MapFrom(input => input.publisher));
        }
    }
    }
