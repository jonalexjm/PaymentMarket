using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMarket.Core.Entities
{
    public class State : BaseEntity
    {
        public int Id { get; set; }
        public string  Description { get; set; }
        public int CountryId { get; set; }
        public Country country { get; set; }
        public virtual ICollection<City> cities { get; set; }

    }
}
