using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMarket.Core.Entities
{
    public class TaxCollector
    {
        public int Id { get; set; }
        public int MarketId { get; set; }
        public Market Market { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public virtual ICollection<PaymentRelation> PaymentRelations { get; set; }
    }
}
