using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMarket.Core.Entities
{
    public class PaymentRelation
    {
        public int Id { get; set; }
        public DateTime DatePayment { get; set; }
        public decimal ValuePayment { get; set; }
        public int TaxCollectorId { get; set; }
        public TaxCollector TaxCollector { get; set; }
        public int CardTaxId { get; set; }
        public CardTax CardTax { get; set; }

        
    }
}
