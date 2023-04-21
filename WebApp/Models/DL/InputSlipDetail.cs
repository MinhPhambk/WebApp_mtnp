using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models.DL
{
    public partial class InputSlipDetail
    {
        public string Id { get; set; }
        public string InputSlipId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual InputSlip InputSlip { get; set; }
        public virtual Product Product { get; set; }
    }
}
