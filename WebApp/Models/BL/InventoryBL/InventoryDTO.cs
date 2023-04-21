
namespace WebApp.Models.BL.InventoryBL
{
    public class InventoryDTO
    {
        public InventoryDTO() { }
        public InventoryDTO(string id, string warehouseId, string productId, int quantity, decimal price)
        {
            this.Id = id;
            this.WarehouseId = warehouseId;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.Price = price;
        }
        public string Id { get; set; }
        public string WarehouseId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
}
