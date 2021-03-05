using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMarket.Core.Entities
{
    public class TypeDocument : BaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
