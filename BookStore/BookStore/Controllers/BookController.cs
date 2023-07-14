using BookStore.Data;
using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookStoresDbContext context;

        //private BookRepository bookRepository;

        public BookController(BookStoresDbContext context)
        {
            this.context = context;
        }
        public ViewResult GetAllBooks()
        {
            var data = context.Books.ToList();

            return View(data);
        }

        [Route("book-details/{id}", Name ="bookDetailsRoute")]
        public ViewResult GetBook(int id)
        {
            //var data = bookRepository.GetBook(id);
            return View();
        }

        //public List<BookModel> SearchBooks(string bookName, string authorName)
        //{
        //    return bookRepository.SearchBook(bookName, authorName);
        //}

        //public ViewResult AddNewBook()
        //{
        //    return View();
        //}

        //[HttpPost(Name ="AddNewBookRoute")]
        //public ViewResult AddNewBook(BookModel bookModel)
        //{
        //    bookRepository.AddBook(bookModel);
        //    return View();
        //}


    }
}
