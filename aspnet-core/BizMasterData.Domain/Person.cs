using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace BizMasterData.Domain
{
    public class Person: AggregateRoot
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Tel { get; set; }
    }
}
