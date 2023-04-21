using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models.DL
{
    public partial class OutputSlipDetail
    {
        public string Id { get; set; }
        public string OutputSlipId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual OutputSlip OutputSlip { get; set; }
        public virtual Product Product { get; set; }
    }
}
