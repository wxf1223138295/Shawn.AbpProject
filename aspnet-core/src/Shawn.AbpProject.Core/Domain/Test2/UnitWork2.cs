using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace Shawn.AbpProject.Domain.Test2
{
    public class UnitWork2:AggregateRoot<int>
    {
        public string workTest1{get; set; }
        public string workTest2 { get; set; }
        public string workTest3 { get; set; }
    }
}
