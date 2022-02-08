
using BookManagementUsing3tierMVCwithJQuery.Core.IRepository;
using BookManagementUsing3tierMVCwithJQuery.Core.Model;
using BookManagementUsing3tierMVCwithJQuery.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using static BookManagementUsing3tierMVCwithJQuery.Core.Model.EnumList;


namespace BookManagementUsing3tierMVCwithJQuery.Resources.Repository
{
    public class Repository : IRepository
    {

        #region AdminLogin
        public string AdminLogin(AdminLoginModel AdminModel)
        {
            var entities = new BookmanagementContext();

            var ValidAdminID = (from p in entities.AdminLogin
                                where p.AdminId == AdminModel.AdminId
                                select p).FirstOrDefault();

            if (ValidAdminID == null)
            {
                return null;
            }
            else if (!MatchPasswordHash(AdminModel.Password, ValidAdminID.AdminPassword, ValidAdminID.AdminPasswordKey))
            {
                return null;
            }
            else
            {
                return ValidAdminID.AdminId;
            }
        }

        public bool MatchPasswordHash(string passwordText, byte[] password, byte[] passwordkey)
        {
            using (var hmac = new HMACSHA512(password))
            {
                var passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(passwordText));

                for (int i = 0; i < passwordHash.Length; i++)
                {
                    if (passwordHash[i] != passwordkey[i])
                        return false;
                }
                return true;
            }
        }


        public void AdminSignUp(AdminLoginModel AdminModel)
        {
            AdminLogin signup = new AdminLogin();
            if (AdminModel != null)
            {
                using (var entities = new BookmanagementContext())
                {
                    var validAdminId = entities.AdminLogin.
                      Where(x => x.AdminId == AdminModel.AdminId).SingleOrDefault();

                    if (validAdminId == null)
                    {
                        signup.AdminId = AdminModel.AdminId;
                        byte[] passwordHash, passwordkey;
                        if(AdminModel.Password==AdminModel.RetypePassword)
                        {
                            using (var hmac = new HMACSHA512())
                            {
                                passwordHash = hmac.Key;
                                passwordkey = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(AdminModel.Password));
                            }
                            signup.AdminPassword = passwordHash;
                            signup.AdminPasswordKey = passwordkey;
                        }
                       
                       
                        signup.CreateTimeStamp = DateTime.Now;
                        signup.UpdateTimeStamp = DateTime.Now;
                        signup.IsDeleted = false;
                        entities.AdminLogin.Add(signup);
                        entities.SaveChanges();
                    }
                }
            }

         }
        #endregion

        #region BookDetail

        public List<BookDetailModel> ViewBookList()
        {
            List<BookDetailModel> ListModel = new List<BookDetailModel>();
            using (var entities = new BookmanagementContext())
            {


                var Booklist = entities.BookDetail.Where(x => x.IsDeleted == false).ToList();

             

                if (Booklist!= null)
               {
                    foreach( var item in Booklist)
                    {
                        BookDetailModel model = new BookDetailModel();
                        model.BookId = item.BookId;
                        model.Title = item.Title;
                        model.Author = item.Author;
                        model.Price = item.Price;

                        ListModel.Add(model);
                    }
               }
                return ListModel;
            }
           
        }

        public BookDetailModel DropList()
        {
            IEnumerable<AuthorList> actionTypes = Enum.GetValues(typeof(AuthorList))
                                            .Cast<AuthorList>();
            BookDetailModel model= new BookDetailModel();

            model.ActionsList = from action in actionTypes
                               select new SelectListItem
                               {
                                   Text = action.ToString(),
                                   Value = action.ToString()
                               };
            
            return model;
        }


        public void AddOrEditBook(BookDetailModel Book)
        {
           using (var entities =new BookmanagementContext())
            {
                BookDetail dbRecord = null;
                bool isrecordExist = false;

                dbRecord = entities.BookDetail.FirstOrDefault(x => x.BookId == Book.BookId && !x.IsDeleted);

                if (dbRecord != null && dbRecord.BookId > 0)
                {
                    isrecordExist = true;
                }
                else
                {
                    dbRecord = new BookDetail();
                }

                if (dbRecord != null)
                {
                    BookDetail detail = new BookDetail();
                    dbRecord.Title = Book.Title;
                    dbRecord.Author = Book.Author;
                    dbRecord.Price = Book.Price;
                    dbRecord.UpdateTimeStamp = DateTime.Now;
                    dbRecord.IsDeleted = false;
                    if (!isrecordExist)
                    {
                        detail.CreateTimeStamp = DateTime.Now;
                        entities.BookDetail.Add(dbRecord);
                    }
                    entities.SaveChanges();

                }
                
            }
        }

        public BookDetailModel BookContent(long id)
        {
            using (var entities = new BookmanagementContext())
            {
                var BookContent = (from p in entities.BookDetail
                                   where p.BookId == id
                                   select p).SingleOrDefault();
                BookDetailModel Model = new BookDetailModel();
                IEnumerable<AuthorList> actionTypes = Enum.GetValues(typeof(AuthorList))
                                           .Cast<AuthorList>();
               

                Model.ActionsList = from action in actionTypes
                                    select new SelectListItem
                                    {
                                        Text = action.ToString(),
                                        Value = action.ToString()
                                    };

                Model.BookId = BookContent.BookId;
                Model.Title = BookContent.Title;
                Model.Author = BookContent.Author;
                Model.Price = BookContent.Price;

                return Model;
            }    
        }


        public void DeleteBook(long id)
        {
            using (var entities = new BookmanagementContext())
            {
                var SelectBook = (from p in entities.BookDetail
                                   where p.BookId == id && p.IsDeleted== false
                                   select p).SingleOrDefault();
                SelectBook.UpdateTimeStamp = DateTime.Now;
                SelectBook.IsDeleted = true;
                entities.Update(SelectBook);
                entities.SaveChanges();

            }

        }
        #endregion

    }
}










