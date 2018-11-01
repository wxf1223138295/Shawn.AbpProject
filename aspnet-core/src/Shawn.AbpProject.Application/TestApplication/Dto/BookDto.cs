using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.AutoMapper;
using Shawn.AbpProject.TestEntity;

namespace Shawn.AbpProject.TestApplication.Dto
{
    [AutoMapTo(typeof(Book))]
    public class BookDto
    {
        [Required]
        public string BookName { get; set; }
        public DateTime BookPublish { get; set; }
        public string publisher { get; set; }
        public decimal pricebook { get; set; }
    }
}
