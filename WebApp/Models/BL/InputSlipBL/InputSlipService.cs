using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.DL;
using System;
using System.Threading.Tasks;

namespace WebApp.Models.BL.InputSlipBL
{
    internal class InputSlipService : IInputSlipService
    {
        private readonly AppDBContext dbContext;

        public InputSlipService(AppDBContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task<string> CreateAsync(InputSlipDTO inputSlipDTO)
        {

            string re = "done";
            try
            {
                // Transfer data from CustomerDTO (model side)
                // to Customer (database side)
                InputSlip inputSlip = new InputSlip();
                inputSlip.Id = inputSlipDTO.Id;
                inputSlip.CustomerId = inputSlipDTO.CustomerId;
                inputSlip.Date = inputSlipDTO.Date;
                inputSlip.WarehouseId = inputSlipDTO.WarehouseId;

                // Add customer to database and save change
                dbContext.InputSlips.Add(inputSlip);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<string> UpdateAsync(InputSlipDTO inputSlipDTO)
        {
            string re = "done";
            try
            {
                // Transfer data from CustomerDTO (model side)
                // to Customer (database side)
                InputSlip inputSlip = new InputSlip();
                inputSlip.Id = inputSlipDTO.Id;
                inputSlip.CustomerId = inputSlipDTO.CustomerId;
                inputSlip.Date = inputSlipDTO.Date;
                inputSlip.WarehouseId = inputSlipDTO.WarehouseId;

                // Update customer to database and save change
                dbContext.InputSlips.Update(inputSlip);
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
                InputSlip inputSlip = await dbContext.InputSlips.FindAsync(id);

                // Delete customer and save change
                dbContext.InputSlips.Remove(inputSlip);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<List<InputSlipDTO>> GetInputSlips()
        {
            List<InputSlip> listInputSlip = await dbContext.InputSlips.ToListAsync();
            List<InputSlipDTO> listInputSlipDTO = new List<InputSlipDTO>();

            if (listInputSlip != null)
            {
                foreach (InputSlip inputSlip in listInputSlip)
                {
                    listInputSlipDTO.Add(new InputSlipDTO(inputSlip.Id, inputSlip.CustomerId, inputSlip.Date, inputSlip.WarehouseId));
                }
            }

            return listInputSlipDTO;
        }
    }
}