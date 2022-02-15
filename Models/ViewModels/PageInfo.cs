using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBBookStore.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPage { get; set; }
        
        //Calculate total pages needed
        public int TotalPages => (int) Math.Ceiling((double)TotalNumBooks / BooksPerPage); //has to be cast as a double, rounded up, and cast back to an int in order to have the correct number of pages
    }
}
