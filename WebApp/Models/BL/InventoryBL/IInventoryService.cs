using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebApp.Models.BL.InventoryBL
{
    public interface IInventoryService
    {
        public Task<List<InventoryDTO>> GetInventorys();
        public Task<string> DeleteAsync(string id);
        public Task<string> CreateAsync(InventoryDTO inventoryDTO);
        public Task<string> UpdateAsync(InventoryDTO inventoryDTO);
    }
}