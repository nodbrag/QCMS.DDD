using System;
using System.Collections.Generic;
using System.Text;
using Sample.Domain.Core.ValueObjects;

namespace Sample.Domain.ValueObjects
{
    public class UserAddress : ValueObject
    {
        public Guid CityId { get; }

        public string Street { get; }

        public int Number { get; }

        public UserAddress(

            Guid cityId,
            string street,
            int number)
        {
            CityId = cityId;
            Street = street;
            Number = number;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Street;
            yield return CityId;
            yield return Number;
        }
    }
}
