using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebApp.Models.BL.WarehouseBL
{
    public interface IWarehouseService
    {
        public Task<List<WarehouseDTO>> GetWarehouses();
        public Task<string> DeleteAsync(string id);
        public Task<string> CreateAsync(WarehouseDTO warehouseDTO);
        public Task<string> UpdateAsync(WarehouseDTO warehouseDTO);
    }
}