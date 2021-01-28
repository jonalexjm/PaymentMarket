using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMarket.Core.Entities
{
    public class SalesStand
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }
        public int MarketId { get; set; }
        public Market Market { get; set; }

        public virtual ICollection<CardTax> CardTaxes { get; set; }
    }
}
