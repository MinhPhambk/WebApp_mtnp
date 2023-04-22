using WebApp.Models;
using WebApp.Models.BL.CustomerBL;
using WebApp.Models.DL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text.RegularExpressions;

namespace WebApp.Controllers

{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> IndexCustomer()
        {
            List<CustomerDTO> listCustomerDTO = await _customerService.GetCustomers();
            return View(listCustomerDTO);
        }


        // To open page CreateCustomer
        public IActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([Bind("Id,Name,Address,Phone")] CustomerDTO customerDTO)
        {
            try
            {
                int countIdIfExist = 0;

                List<CustomerDTO> listCustomerDTO = await _customerService.GetCustomers();
                countIdIfExist = listCustomerDTO.Count(c => c.Id == customerDTO.Id);

                if (countIdIfExist == 0)
                {
                    await _customerService.CreateAsync(customerDTO);
                    ViewBag.Message = "Form was created successfully!";
                    return View(customerDTO);
                }
                else
                {
                    ViewBag.Message = "Id existed!";
                }

                return View();
            }
            catch
            {
                ViewBag.Message = "Value error!";
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteCustomer(string id)
        {
            if (id == "")
            {
                return NotFound();
            }
            CustomerDTO customerDTO = new CustomerDTO();
            customerDTO.Id = id;
            return View(customerDTO);
        }
                  
       
        [HttpPost]
        public async Task<IActionResult> DeleteCustomer([Bind("Id")] CustomerDTO customerDTO)
        {
            try
            {
                int countIdIfExist = 0;

                List<CustomerDTO> listCustomerDTO = await _customerService.GetCustomers();
                countIdIfExist = listCustomerDTO.Count(c => c.Id == customerDTO.Id);

                if (countIdIfExist == 0)
                {
                    ViewBag.Message = "Id doesn't existed!";
                }
                else
                {
                    await _customerService.DeleteAsync(customerDTO.Id);
                    ViewBag.Message = "Form was deleted successfully!";
                    return View(customerDTO);
                }

                return View();
            }
            catch
            {
                ViewBag.Message = "Value error!";
                return View();
            }
        }

       
        [HttpPost]
        public async Task<IActionResult> UpdateCustomer([Bind("Id,Name,Address,Phone")] CustomerDTO customerDTO)
        {
            try
            {
                await _customerService.UpdateAsync(customerDTO);
                ViewBag.Message = "Customer was updated successfully!";
                return View(customerDTO);
            }
            catch
            {
                ViewBag.Message = "Value error!";
                return View();
            }
        }
    }
}
