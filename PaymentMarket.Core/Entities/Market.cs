using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMarket.Core.Entities
{
    public class Market
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }

        public virtual ICollection<TaxCollector> TaxCollectors { get; set; }
    }
}
