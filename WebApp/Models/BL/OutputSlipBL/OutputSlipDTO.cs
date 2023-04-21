using System;
using System.Collections.Generic;

namespace WebApp.Models.BL.OutputSlipBL
{
    public class OutputSlipDTO
    {
        public OutputSlipDTO() { }
        public OutputSlipDTO(string id, string customerId, DateTime date, string warehouseId)
        {
            this.Id = id;
            this.CustomerId = customerId;
            this.Date = date;
            this.WarehouseId = warehouseId;
        }
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string WarehouseId { get; set; }

    }
}

