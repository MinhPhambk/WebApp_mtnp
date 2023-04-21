
namespace WebApp.Models.BL.WarehouseBL
{
    public class WarehouseDTO
    {
        public WarehouseDTO() { }
        public WarehouseDTO(string id, string name, string address, string nameKeeper)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.NameKeeper = nameKeeper;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string NameKeeper { get; set; }

    }
}