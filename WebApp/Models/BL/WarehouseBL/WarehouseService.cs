using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.DL;
using System;
using System.Threading.Tasks;

namespace WebApp.Models.BL.WarehouseBL
{
    internal class WarehouseService : IWarehouseService
    {
        private readonly AppDBContext dbContext;

        public WarehouseService(AppDBContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task<string> CreateAsync(WarehouseDTO warehouseDTO)
        {

            string re = "done";
            try
            {
                // Transfer data from CustomerDTO (model side)
                // to Customer (database side)
                Warehouse warehouse = new Warehouse();
                warehouse.Id = warehouseDTO.Id;
                warehouse.Name = warehouseDTO.Name;
                warehouse.Address = warehouseDTO.Address;
                warehouse.NameKeeper = warehouseDTO.NameKeeper;

                // Add customer to database and save change
                dbContext.Warehouses.Add(warehouse);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<string> UpdateAsync(WarehouseDTO warehouseDTO)
        {
            string re = "done";
            try
            {
                Warehouse warehouse = new Warehouse();
                warehouse.Id = warehouseDTO.Id;
                warehouse.Name = warehouseDTO.Name;
                warehouse.Address = warehouseDTO.Address;
                warehouse.NameKeeper = warehouseDTO.NameKeeper;

                // Update customer to database and save change
                dbContext.Warehouses.Update(warehouse);
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
                // Find customer whose id == id_was_given
                Warehouse warehouse = await dbContext.Warehouses.FindAsync(id);

                // Delete customer and save change
                dbContext.Warehouses.Remove(warehouse);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<List<WarehouseDTO>> GetWarehouses()
        {
            List<Warehouse> listWarehouse = await dbContext.Warehouses.ToListAsync();
            List<WarehouseDTO> listWarehouseDTO = new List<WarehouseDTO>();

            if (listWarehouse != null)
            {
                foreach (Warehouse warehouse in listWarehouse)
                {
                    listWarehouseDTO.Add(new WarehouseDTO(warehouse.Id, warehouse.Name, warehouse.Address, warehouse.NameKeeper));
                }
            }

            return listWarehouseDTO;
        }
    }
}