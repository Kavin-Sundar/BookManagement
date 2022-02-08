using BookManagementUsing3tierMVCwithJQuery.Core.IServices;
using BookManagementUsing3tierMVCwithJQuery.Core.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BookManagementUsing3tierMVCwithJQuery.Controllers
{
    public class BookDetailController : Controller
    {
        IServices _Iservices;

        public BookDetailController(IServices Iservices)
        {
            _Iservices = Iservices;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllBooks()
        {
         List<BookDetailModel>  booklist = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:39069/BookApi/GetAllBooks");

                //HttpGet
                var responseTask = client.GetAsync(client.BaseAddress);
                responseTask.Wait();

                ViewBag.Message = "Deleted Successfull";


                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<BookDetailModel>>();
                    readTask.Wait();
                    booklist = readTask.Result;
                    return View(booklist);

                }
            }

           
            return View();
        }
        public IActionResult AddBook()
        {
            BookDetailModel book = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:39069/BookApi/DropList");

                //HttpGet
                var responseTask = client.GetAsync(client.BaseAddress);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<BookDetailModel>();
                    readTask.Wait();
                    book = readTask.Result;
                    return View(book);

                }
            }
    
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(BookDetailModel BookModel)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:39069/BookApi/AddBook");

                    //HttpPost
                    var postTask = client.PostAsJsonAsync<BookDetailModel>(client.BaseAddress, BookModel);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("GetAllBooks");
                    }
                }

            }
            ModelState.AddModelError(string.Empty, "Server Error,Please contact administrator");
            return View(BookModel);
        }        
        public IActionResult EditBook(long id)
        {
            BookDetailModel book = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:39069/BookApi/");

                //HttpGet
                var responseTask = client.GetAsync("BookContent?id=" + id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<BookDetailModel>();
                    readTask.Wait();
                    book = readTask.Result;
                    return View(book);

                }
            }

            return View();
        }
        [HttpPost]
        public IActionResult EditBook(BookDetailModel BookModel)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:39069/BookApi/EditBook");

                    //HttpPost
                    var postTask = client.PutAsJsonAsync<BookDetailModel>(client.BaseAddress, BookModel);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("GetAllBooks");
                    }
                }

            }
            ModelState.AddModelError(string.Empty, "Server Error,Please contact administrator");
            return View(BookModel);
        }
        [HttpPost]
        public IActionResult DeleteBook(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:39069/BookApi/");

                //HttpGet
                var responseTask = client.DeleteAsync("DeleteBook?id=" + id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("GetAllBooks");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server Error,Please contact administrator");
                    return RedirectToAction("GetAllBooks");
                }
            }   
            
        }
    }
    
}
