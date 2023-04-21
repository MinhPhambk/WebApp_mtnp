using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.DL;
using System;
using System.Threading.Tasks;

namespace WebApp.Models.BL.InputSlipDetailBL
{
    internal class InputSlipDetailService : IInputSlipDetailService
    {
        private readonly AppDBContext dbContext;

        public InputSlipDetailService(AppDBContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task<string> CreateAsync(InputSlipDetailDTO inputSlipDetailDTO)
        {

            string re = "done";
            try
            {
                // Transfer data from CustomerDTO (model side)
                // to Customer (database side)
                InputSlipDetail inputSlipDetail = new InputSlipDetail();
                inputSlipDetail.Id = inputSlipDetailDTO.Id;
                inputSlipDetail.InputSlipId = inputSlipDetailDTO.InputSlipId;
                inputSlipDetail.ProductId = inputSlipDetailDTO.ProductId;
                inputSlipDetail.Quantity = inputSlipDetailDTO.Quantity;
                inputSlipDetail.Price = inputSlipDetailDTO.Price;

                // Add customer to database and save change
                dbContext.InputSlipDetails.Add(inputSlipDetail);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<string> UpdateAsync(InputSlipDetailDTO inputSlipDetailDTO)
        {
            string re = "done";
            try
            {
                // Transfer data from CustomerDTO (model side)
                // to Customer (database side)
                InputSlipDetail inputSlipDetail = new InputSlipDetail();
                inputSlipDetail.Id = inputSlipDetailDTO.Id;
                inputSlipDetail.InputSlipId = inputSlipDetailDTO.InputSlipId;
                inputSlipDetail.ProductId = inputSlipDetailDTO.ProductId;
                inputSlipDetail.Quantity = inputSlipDetailDTO.Quantity;
                inputSlipDetail.Price = inputSlipDetailDTO.Price;

                // Update customer to database and save change
                dbContext.InputSlipDetails.Update(inputSlipDetail);
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
                InputSlipDetail inputSlipDetail = await dbContext.InputSlipDetails.FindAsync(id);

                // Delete customer and save change
                dbContext.InputSlipDetails.Remove(inputSlipDetail);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<List<InputSlipDetailDTO>> GetInputSlipDetails()
        {
            List<InputSlipDetail> listInputSlipDetail = await dbContext.InputSlipDetails.ToListAsync();
            List<InputSlipDetailDTO> listInputSlipDetailDTO = new List<InputSlipDetailDTO>();

            if (listInputSlipDetail != null)
            {
                foreach (InputSlipDetail inputSlipDetail in listInputSlipDetail)
                {
                    listInputSlipDetailDTO.Add(new InputSlipDetailDTO(inputSlipDetail.Id, inputSlipDetail.InputSlipId, inputSlipDetail.ProductId, inputSlipDetail.Quantity, inputSlipDetail.Price));
                }
            }

            return listInputSlipDetailDTO;
        }
    }
}