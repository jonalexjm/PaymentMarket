﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMarket.Core.Entities
{
    public class Menu : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }

    }
}
