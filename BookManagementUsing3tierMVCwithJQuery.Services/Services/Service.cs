using BookManagementUsing3tierMVCwithJQuery.Core.IRepository;
using BookManagementUsing3tierMVCwithJQuery.Core.IServices;
using BookManagementUsing3tierMVCwithJQuery.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementUsing3tierMVCwithJQuery.Services.Services
{


  

        public class Service : IServices
        {
            IRepository _repository;

            public Service(IRepository repository)
            {
                _repository = repository;
            }
            public string AdminLogin(AdminLoginModel AdminModel)
            {
                string a = _repository.AdminLogin(AdminModel);
                return a;
            }
            public void AdminSignUp(AdminLoginModel AdminModel)
            {
                _repository.AdminSignUp(AdminModel);
            }

            public List<BookDetailModel> ViewBookList()
            {
             return  _repository.ViewBookList();
            }
           public void AddOrEditBook(BookDetailModel Book)
           {
                _repository.AddOrEditBook(Book);
           }

           public BookDetailModel BookContent(long id)
           {
            return  _repository.BookContent(id);
           }
           
           public void DeleteBook(long id)
           {
            _repository.DeleteBook(id);
           }
          public BookDetailModel DropList()
          {
            return _repository.DropList();
          }
    }
    

}
