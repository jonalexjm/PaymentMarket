using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMarket.Core.Entities
{
    public class City : BaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }
}
