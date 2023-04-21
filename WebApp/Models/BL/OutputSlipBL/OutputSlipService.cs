using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.DL;
using System;
using System.Threading.Tasks;

namespace WebApp.Models.BL.OutputSlipBL
{
    internal class OutputSlipService : IOutputSlipService
    {
        private readonly AppDBContext dbContext;

        public OutputSlipService(AppDBContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task<string> CreateAsync(OutputSlipDTO outputSlipDTO)
        {

            string re = "done";
            try
            {
                // Transfer data from CustomerDTO (model side)
                // to Customer (database side)
                OutputSlip outputSlip = new OutputSlip();
                outputSlip.Id = outputSlipDTO.Id;
                outputSlip.CustomerId = outputSlipDTO.CustomerId;
                outputSlip.Date = outputSlipDTO.Date;
                outputSlip.WarehouseId = outputSlipDTO.WarehouseId;

                // Add customer to database and save change
                dbContext.OutputSlips.Add(outputSlip);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<string> UpdateAsync(OutputSlipDTO outputSlipDTO)
        {
            string re = "done";
            try
            {
                OutputSlip outputSlip = new OutputSlip();
                outputSlip.Id = outputSlipDTO.Id;
                outputSlip.CustomerId = outputSlipDTO.CustomerId;
                outputSlip.Date = outputSlipDTO.Date;
                outputSlip.WarehouseId = outputSlipDTO.WarehouseId;

                dbContext.OutputSlips.Update(outputSlip);
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
                OutputSlip outputSlip = await dbContext.OutputSlips.FindAsync(id);

                // Delete customer and save change
                dbContext.OutputSlips.Remove(outputSlip);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<List<OutputSlipDTO>> GetOutputSlips()
        {
            List<OutputSlip> listOutputSlip = await dbContext.OutputSlips.ToListAsync();
            List<OutputSlipDTO> listOutputSlipDTO = new List<OutputSlipDTO>();

            if (listOutputSlip != null)
            {
                foreach (OutputSlip outputSlip in listOutputSlip)
                {
                    listOutputSlipDTO.Add(new OutputSlipDTO(outputSlip.Id, outputSlip.CustomerId, outputSlip.Date, outputSlip.WarehouseId));
                }
            }

            return listOutputSlipDTO;
        }
    }
}
