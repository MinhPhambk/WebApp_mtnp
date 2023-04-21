using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp.Models.DL
{
    public partial class Customer
    {
        public Customer()
        {
            InputSlips = new HashSet<InputSlip>();
            OutputSlips = new HashSet<OutputSlip>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<InputSlip> InputSlips { get; set; }
        public virtual ICollection<OutputSlip> OutputSlips { get; set; }
    }
}
