using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.DL;
using System;
using System.Threading.Tasks;

namespace WebApp.Models.BL.ProductBL
{
    internal class ProductService : IProductService
    {
        private readonly AppDBContext dbContext;

        public ProductService(AppDBContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task<string> CreateAsync(ProductDTO productDTO)
        {

            string re = "done";
            try
            {
                // Transfer data from CustomerDTO (model side)
                // to Customer (database side)
                Product product = new Product();
                product.Id = productDTO.Id;
                product.Name = productDTO.Name;
                product.WarehouseId = product.WarehouseId;
                product.Unit = product.Unit;

                // Add customer to database and save change
                dbContext.Products.Add(product);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<string> UpdateAsync(ProductDTO productDTO)
        {
            string re = "done";
            try
            {
                Product product = new Product();
                product.Id = productDTO.Id;
                product.Name = productDTO.Name;
                product.WarehouseId = product.WarehouseId;
                product.Unit = product.Unit;

                // Update customer to database and save change
                dbContext.Products.Update(product);
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
                Product product = await dbContext.Products.FindAsync(id);

                // Delete customer and save change
                dbContext.Products.Remove(product);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<List<ProductDTO>> GetProducts()
        {
            List<Product> listProduct = await dbContext.Products.ToListAsync();
            List<ProductDTO> listProductDTO = new List<ProductDTO>();

            if (listProduct != null)
            {
                foreach (Product product in listProduct)
                {
                    listProductDTO.Add(new ProductDTO(product.Id, product.Name, product.WarehouseId, product.Unit));
                }
            }

            return listProductDTO;
        }
    }
}