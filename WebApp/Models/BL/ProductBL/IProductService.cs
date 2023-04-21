using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebApp.Models.BL.ProductBL
{
    public interface IProductService
    {
        public Task<List<ProductDTO>> GetProducts();
        public Task<string> DeleteAsync(string id);
        public Task<string> CreateAsync(ProductDTO productDTO);
        public Task<string> UpdateAsync(ProductDTO productDTO);
    }
}