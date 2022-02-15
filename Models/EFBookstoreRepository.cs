using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBBookStore.Models
{
    //Inherits from the IBookstoreRepository
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookstoreRepository(BookstoreContext temp)
        {
            context = temp;
        }
        //The datatype is a Queryable object, not a list anymore
        public IQueryable<Book> Books => context.Books;
    }
}
