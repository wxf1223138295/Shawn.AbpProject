using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace Shawn.AbpProject.Domain.Test1
{
    public class UnitWork1:AggregateRoot<int>
    {
        public string test1 { get; set; }
        public string test2 { get; set; }
        public string test3 { get; set; }
    }
}
