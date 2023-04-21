using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models.DL
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            InputSlips = new HashSet<InputSlip>();
            Inventories = new HashSet<Inventory>();
            OutputSlips = new HashSet<OutputSlip>();
            Products = new HashSet<Product>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string NameKeeper { get; set; }

        public virtual ICollection<InputSlip> InputSlips { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<OutputSlip> OutputSlips { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
