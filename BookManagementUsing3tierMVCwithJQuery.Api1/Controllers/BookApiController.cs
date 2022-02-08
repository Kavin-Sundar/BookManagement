
using BookManagementUsing3tierMVCwithJQuery.Core.IServices;
using BookManagementUsing3tierMVCwithJQuery.Core.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagementUsing3tierMVCwithJQuery.Api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookApiController : Controller
    {
        readonly IServices _Iservices;

        public BookApiController(IServices Iservices)
        {
            _Iservices = Iservices;
        }

        [HttpPost]
        public IActionResult Login(AdminLoginModel admin)
        {
            string AdminValidId = _Iservices.AdminLogin(admin);

            if (AdminValidId != null)
            {

                return Ok(AdminValidId);


            }
            return Ok();
        }
        [HttpPost]
        public IActionResult SignUp(AdminLoginModel admin)
        {
            if (ModelState.IsValid)
            {
                _Iservices.AdminSignUp(admin);
                return Ok();
            }
            return NotFound(admin);

        }

    }

}
