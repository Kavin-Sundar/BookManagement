using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using static BookManagementUsing3tierMVCwithJQuery.Core.Model.EnumList;

namespace BookManagementUsing3tierMVCwithJQuery.Core.Model
{
    public class BookDetailModel
    {
        public long BookId { get; set; }
        public string Title { get; set; }
        //  public  AuthorList Author{ get; set; }
       
        public long Price { get; set; }
        public DateTime? CreateTimeStamp { get; set; }
        public DateTime? UpdateTimeStamp { get; set; }
        public bool? IsDeleted { get; set; }


        public BookDetailModel()
        {
            ActionsList = new List<SelectListItem>();
        }

        public IEnumerable<SelectListItem> ActionsList { get; set; }

      
      
        public string Author{ get; set; }
        public enum AuthorList
        {
            Kavin,
            Arun,
            Sundar,
            Selvam,
            jai
        }
    }
}
   


