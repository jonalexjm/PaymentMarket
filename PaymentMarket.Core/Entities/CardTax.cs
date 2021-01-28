using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMarket.Core.Entities
{
    public class CardTax
    {
        public int Id { get; set; }
        public decimal FeePayment { get; set; }
        public int AnnioId { get; set; }
        public Annio Annio { get; set; }
        public int SalesStandId { get; set; }
        public SalesStand SalesStand { get; set; }

        public virtual ICollection<PaymentRelation> PaymentRelations { get; set; }
    }
}
