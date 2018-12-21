using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities;

namespace Shawn.AbpProject.TestEntity
{
    public class Book : Entity
    {
        [Required]
        public string BookName { get; set; }
        public DateTime BookPublish { get; set; }
        public string publisher { get; set; }
        public decimal pricebook { get; set; }
        public PublisherInfo _PublisherInfo { get; private set; }
    }
}
