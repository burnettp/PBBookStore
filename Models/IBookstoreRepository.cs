using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PBBookStore.Models
{
    //Interfaces are not classes, but templates for classes
    public interface IBookstoreRepository
    {
        //Similar to a list. You can read it, but you can't write to this because we are saying get only
        IQueryable<Book> Books { get; }

        public void SaveBook(Book b);
        public void CreateBook(Book b);
        public void DeleteBook(Book b);
    }
}
