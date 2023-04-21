using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.DL;
using System;
using System.Threading.Tasks;

namespace WebApp.Models.BL.CustomerBL
{
    internal class CustomerService : ICustomerService
    {
        private readonly AppDBContext dbContext;

        public CustomerService(AppDBContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task<string> CreateAsync(CustomerDTO customerDTO)
        {

            string re = "done";
            try
            {
                // Transfer data from CustomerDTO (model side)
                // to Customer (database side)
                Customer customer = new Customer();
                customer.Id = customerDTO.Id;
                customer.Name = customerDTO.Name;
                customer.Address = customerDTO.Address;
                customer.Phone = customerDTO.Phone;

                // Add customer to database and save change
                dbContext.Customers.Add(customer);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<string> UpdateAsync(CustomerDTO customerDTO)
        {
            string re = "done";
            try
            {
                // Transfer data from CustomerDTO (model side)
                // to Customer (database side)
                Customer customer = new Customer();
                customer.Id = customerDTO.Id;
                customer.Name = customerDTO.Name;
                customer.Address = customerDTO.Address;
                customer.Phone = customerDTO.Phone;

                // Update customer to database and save change
                dbContext.Customers.Update(customer);
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
                Customer customer = await dbContext.Customers.FindAsync(id);

                // Delete customer and save change
                dbContext.Customers.Remove(customer);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<List<CustomerDTO>> GetCustomers()
        {
            List<Customer> listCustomer = await dbContext.Customers.ToListAsync();
            List<CustomerDTO> listCustomerDTO = new List<CustomerDTO>();

            if (listCustomer != null)
            {
                foreach (Customer customer in listCustomer)
                {
                    listCustomerDTO.Add(new CustomerDTO(customer.Id, customer.Name, customer.Address, customer.Phone));
                }
            }

            return listCustomerDTO;
        }
    }
}