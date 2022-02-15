using Microsoft.AspNetCore.Mvc;
using PBBookStore.Models;
using PBBookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBBookStore.Controllers
{
    public class HomeController : Controller
    {
        //This is all being done in the Models now using the Repository pattern
        //private BookstoreContext context { get; set; }
        //public HomeController (BookstoreContext temp)
        //{
        //    context = temp;
        //    // alternatively, I could write public HomeController (BookstoreContext temp) => context = temp;
        //}

        private IBookstoreRepository repo;
        
        public HomeController (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(int pageNum = 1) //don't ever use 'page' because that name is reserved and it will break
        {
            int pageSize = 10; //this will be the number of results we see per page

            var x = new BooksViewModel
            {
                Books = repo.Books
                .OrderBy(x => x.Title) //Orders the results
                .Skip((pageNum - 1) * pageSize) //skips 5 records, starts at page 0 (1) because it multiplies by 5
                .Take(pageSize), //Only shows 'pageSize' results

                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };
            return View(x);
        }
    }
}
