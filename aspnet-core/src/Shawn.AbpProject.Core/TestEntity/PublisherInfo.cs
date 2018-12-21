using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Values;

namespace Shawn.AbpProject.TestEntity
{
    public class PublisherInfo: ValueObject<PublisherInfo>
    {
        public Guid CityId { get; private set; } //A reference to a City entity.

        public string Street { get; private set; }

        public int Number { get; private set; }
        public int sss { get; private set; }
        public PublisherInfo(Guid cityId, string street, int number)
        {
            CityId = cityId;
            Street = street;
            Number = number;
        }
    }
}
