
using BookManagementUsing3tierMVCwithJQuery.Core.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;



namespace BookManagementUsing3tierMVCwithJQuery.Controllers
{
    public class AdminController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginView(int id)
        {
            if (id == 1)
            {
                ViewBag.Message = "Invalid Username or Password";
            }
           

            return View();
        }

        public IActionResult Login(AdminLoginModel admin)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:39069/BookApi/Login");

                //HttpPost
                var postTask = client.PostAsJsonAsync<AdminLoginModel>(client.BaseAddress, admin);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("GetAllBooks", "BookDetail");
                }


            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");


            
            return RedirectToAction("LoginView", new { id = 1  });
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(AdminLoginModel admin)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:39069/BookApi/SignUp");

                    //HttpPost
                    var postTask = client.PostAsJsonAsync<AdminLoginModel>(client.BaseAddress, admin);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("LoginView");
                    }
                }

            }
            ModelState.AddModelError(string.Empty, "Server Error,Please contact administrator");
            return View(admin);
        }
    }
}








