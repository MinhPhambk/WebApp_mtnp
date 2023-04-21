using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.DL;
using System;
using System.Threading.Tasks;

namespace WebApp.Models.BL.OutputSlipDetailBL
{
    internal class OutputSlipDetailService : IOutputSlipDetailService
    {
        private readonly AppDBContext dbContext;

        public OutputSlipDetailService(AppDBContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task<string> CreateAsync(OutputSlipDetailDTO outputSlipDetailDTO)
        {

            string re = "done";
            try
            {
                // Transfer data from CustomerDTO (model side)
                // to Customer (database side)
                OutputSlipDetail outputSlipDetail = new OutputSlipDetail();
                outputSlipDetail.Id = outputSlipDetailDTO.Id;
                outputSlipDetail.OutputSlipId = outputSlipDetailDTO.OutputSlipId;
                outputSlipDetail.ProductId = outputSlipDetailDTO.ProductId;
                outputSlipDetail.Quantity = outputSlipDetailDTO.Quantity;
                outputSlipDetail.Price = outputSlipDetailDTO.Price;

                // Add customer to database and save change
                dbContext.OutputSlipDetails.Add(outputSlipDetail);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<string> UpdateAsync(OutputSlipDetailDTO outputSlipDetailDTO)
        {
            string re = "done";
            try
            {
                // Transfer data from CustomerDTO (model side)
                // to Customer (database side)

                OutputSlipDetail outputSlipDetail = new OutputSlipDetail();
                outputSlipDetail.Id = outputSlipDetailDTO.Id;
                outputSlipDetail.OutputSlipId = outputSlipDetailDTO.OutputSlipId;
                outputSlipDetail.ProductId = outputSlipDetailDTO.ProductId;
                outputSlipDetail.Quantity = outputSlipDetailDTO.Quantity;
                outputSlipDetail.Price = outputSlipDetailDTO.Price;

                // Update customer to database and save change
                dbContext.OutputSlipDetails.Update(outputSlipDetail);
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
                OutputSlipDetail outputSlipDetail = await dbContext.OutputSlipDetails.FindAsync(id);

                // Delete customer and save change
                dbContext.OutputSlipDetails.Remove(outputSlipDetail);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<List<OutputSlipDetailDTO>> GetOutputSlipDetails()
        {
            List<OutputSlipDetail> listOutputSlipDetail = await dbContext.OutputSlipDetails.ToListAsync();
            List<OutputSlipDetailDTO> listOutputSlipDetailDTO = new List<OutputSlipDetailDTO>();

            if (listOutputSlipDetail != null)
            {
                foreach (OutputSlipDetail outputSlipDetail in listOutputSlipDetail)
                {
                    listOutputSlipDetailDTO.Add(new OutputSlipDetailDTO(outputSlipDetail.Id, outputSlipDetail.OutputSlipId, outputSlipDetail.ProductId, outputSlipDetail.Quantity, outputSlipDetail.Price));
                }
            }

            return listOutputSlipDetailDTO;
        }
    }
}