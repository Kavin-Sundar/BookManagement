using BookManagementUsing3tierMVCwithJQuery.Core.IServices;
using BookManagementUsing3tierMVCwithJQuery.Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagementUsing3tierMVCwithJQuery.Api.Controllers
{
    [Route("[controller]/[action]")]
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
            return NotFound();
        }
        [HttpGet]
        public IActionResult DropList()
        {
            var b = _Iservices.DropList();
            return Ok(b);
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
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var list = _Iservices.ViewBookList();
            return Ok(list);
        }

        [HttpPost]
        public IActionResult AddBook(BookDetailModel BookModel)
        {
            if (ModelState.IsValid)
            {
                _Iservices.AddOrEditBook(BookModel);
                return Ok();
            }
            return NotFound(BookModel);
        }
        [HttpGet]
        public IActionResult BookContent(long id)
        {
            var detail = _Iservices.BookContent(id);
            return Ok(detail);
        }

        [HttpPut]
        public IActionResult EditBook(BookDetailModel BookModel)
        {
            _Iservices.AddOrEditBook(BookModel);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteBook(int id)
        {

            _Iservices.DeleteBook(id);
            return Ok();
        }
    }
}
