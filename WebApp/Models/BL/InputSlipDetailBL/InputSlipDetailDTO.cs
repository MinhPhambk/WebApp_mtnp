using System;
using System.Collections.Generic;

namespace WebApp.Models.BL.InputSlipDetailBL
{
    public class InputSlipDetailDTO
    {
        public InputSlipDetailDTO() { }
        public InputSlipDetailDTO(string id, string inputSlipId, string productId, int quantity, decimal price)
        {
            this.Id = id;
            this.InputSlipId = inputSlipId;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.Price = price;
        }
        public string Id { get; set; }
        public string InputSlipId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}