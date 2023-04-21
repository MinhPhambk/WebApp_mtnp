using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.DL;
using System;
using System.Threading.Tasks;

namespace WebApp.Models.BL.InventoryBL
{
    internal class InventoryService : IInventoryService
    {
        private readonly AppDBContext dbContext;

        public InventoryService(AppDBContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task<string> CreateAsync(InventoryDTO inventoryDTO)
        {

            string re = "done";
            try
            {
                // Transfer data from CustomerDTO (model side)
                // to Customer (database side)
                Inventory inventory = new Inventory();
                inventory.Id = inventoryDTO.Id;
                inventory.WarehouseId = inventoryDTO.WarehouseId;
                inventory.ProductId = inventoryDTO.ProductId;
                inventory.Quantity = inventoryDTO.Quantity;
                inventory.Price = inventoryDTO.Price;

                // Add customer to database and save change
                dbContext.Inventories.Add(inventory);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<string> UpdateAsync(InventoryDTO inventoryDTO)
        {
            string re = "done";
            try
            {
                // Transfer data from CustomerDTO (model side)
                // to Customer (database side)
                Inventory inventory = new Inventory();
                inventory.Id = inventoryDTO.Id;
                inventory.WarehouseId = inventoryDTO.WarehouseId;
                inventory.ProductId = inventoryDTO.ProductId;
                inventory.Quantity = inventoryDTO.Quantity;
                inventory.Price = inventoryDTO.Price;

                // Update customer to database and save change
                dbContext.Inventories.Update(inventory);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<string> DeleteAsync(string id)
        {
            string re = "done";
            try
            {
                Inventory inventory = await dbContext.Inventories.FindAsync(id);

                dbContext.Inventories.Remove(inventory);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<List<InventoryDTO>> GetInventorys()
        {
            List<Inventory> listInventory = await dbContext.Inventories.ToListAsync();
            List<InventoryDTO> listInventoryDTO = new List<InventoryDTO>();

            if (listInventory != null)
            {
                foreach (Inventory inventory in listInventory)
                {
                    listInventoryDTO.Add(new InventoryDTO(inventory.Id, inventory.WarehouseId, inventory.ProductId, inventory.Quantity, inventory.Price));
                }
            }

            return listInventoryDTO;
        }
    }
}