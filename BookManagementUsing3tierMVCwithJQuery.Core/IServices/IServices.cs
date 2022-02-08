using BookManagementUsing3tierMVCwithJQuery.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementUsing3tierMVCwithJQuery.Core.IServices
{
    public interface IServices
    {
        string AdminLogin(AdminLoginModel admin);

        void AdminSignUp(AdminLoginModel admin);

        List<BookDetailModel> ViewBookList();

        public BookDetailModel DropList();

        void AddOrEditBook(BookDetailModel book);

        BookDetailModel BookContent(long id);

        void DeleteBook(long id);
       
    }


}
