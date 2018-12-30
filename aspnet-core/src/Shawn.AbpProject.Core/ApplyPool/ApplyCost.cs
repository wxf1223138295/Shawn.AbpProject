using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;

namespace Shawn.AbpProject.ApplyPool
{
    public class ApplyCost:AggregateRoot
    {
        public string yearNum;
        public decimal CurrentDecimal;

        public ApplyCost()
        {

        }
        public ApplyCost(string _yearNum, decimal _CurrentDecimal)
        {
            yearNum = _yearNum;
            CurrentDecimal = _CurrentDecimal;
        }
    }
}
