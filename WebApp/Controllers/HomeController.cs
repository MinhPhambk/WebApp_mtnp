using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.Models.BL.CustomerBL;
using WebApp.Models.BL.UserLoginBL;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerService _customerService;

        public HomeController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<IActionResult> LoginPage()
        {
            return View();
        }

        public async Task<IActionResult> Login(UserLoginDTO model)
        {
            if (model.UserName == "sa" && model.Password == "123456")
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, model.UserName),
                    new Claim(ClaimTypes.Role, "Admin"),
                };

                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    principal,
                    new AuthenticationProperties()
                    {
                        //IsPersistent = objLoginModel.RememberLogin
                    }
                );

                return RedirectToAction("Index");
            }
            
            return RedirectToAction("LoginPage", "Home");
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("");
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
