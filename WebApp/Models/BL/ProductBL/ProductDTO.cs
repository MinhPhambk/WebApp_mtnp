
namespace WebApp.Models.BL.ProductBL
{
    public class ProductDTO
    {
        public ProductDTO() { }
        public ProductDTO(string id, string name, string warehouseId, string unit)
        {
            this.Id = id;
            this.Name = name;
            this.WarehouseId = warehouseId;
            this.Unit = unit;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string WarehouseId { get; set; }
        public string Unit { get; set; }

    }
}

