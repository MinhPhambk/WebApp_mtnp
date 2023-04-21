using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.Models.BL.CustomerBL;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerService _customerService;

        public HomeController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<CustomerDTO> listCustomerDTO = await _customerService.GetCustomers();
            return View(listCustomerDTO);
        }

        // To open page CreateCustomer
        public IActionResult CreateCustomer()
        {
            return View();
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

        public IActionResult UpdateCustomer()
        {
            return View();
        }

        // To create a customer
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

        [HttpGet]
        public async Task<IActionResult> UpdateCustomer(string id)
        {
            if (id == "")
            {
                return NotFound();
            }
            CustomerDTO customerDTO = new CustomerDTO();
            List<CustomerDTO> listCustomerDTO = await _customerService.GetCustomers();
            customerDTO = listCustomerDTO.Find(cus => cus.Id == id);
            return View(customerDTO);
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
