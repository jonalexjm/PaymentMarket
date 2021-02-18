using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentMarket.Core.Entities
{
    public class SubMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MenuId { get; set; }
        public Menu menus { get; set; }
    }
}
