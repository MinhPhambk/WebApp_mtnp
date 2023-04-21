using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models.DL
{
    public partial class OutputSlip
    {
        public OutputSlip()
        {
            OutputSlipDetails = new HashSet<OutputSlipDetail>();
        }

        public string Id { get; set; }
        public string CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string WarehouseId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual ICollection<OutputSlipDetail> OutputSlipDetails { get; set; }
    }
}
