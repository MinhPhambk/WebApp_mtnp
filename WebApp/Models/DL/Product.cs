using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models.DL
{
    public partial class Product
    {
        public Product()
        {
            InputSlipDetails = new HashSet<InputSlipDetail>();
            Inventories = new HashSet<Inventory>();
            OutputSlipDetails = new HashSet<OutputSlipDetail>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string WarehouseId { get; set; }
        public string Unit { get; set; }

        public virtual Warehouse Warehouse { get; set; }
        public virtual ICollection<InputSlipDetail> InputSlipDetails { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<OutputSlipDetail> OutputSlipDetails { get; set; }
    }
}
