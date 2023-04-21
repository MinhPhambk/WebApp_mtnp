using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebApp.Models.BL.CustomerBL
{
    public interface ICustomerService
    {
        public Task<List<CustomerDTO>> GetCustomers();
        public Task<string> DeleteAsync(string id);
        public Task<string> CreateAsync(CustomerDTO customerDTO);
        public Task<string> UpdateAsync(CustomerDTO customerDTO);
    }
}