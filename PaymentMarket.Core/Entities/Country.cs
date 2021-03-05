using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMarket.Core.Entities
{
    public class Country : BaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}
