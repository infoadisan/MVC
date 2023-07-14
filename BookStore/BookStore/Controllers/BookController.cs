using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private BookRepository bookRepository;
        public BookController()
        {
            bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = bookRepository.GetAllBooks();

            return View(data);
        }

        [Route("book-details/{id}", Name ="bookDetailsRoute")]
        public ViewResult GetBook(int id)
        {
            var data = bookRepository.GetBook(id);
            return View(data);
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return bookRepository.SearchBook(bookName, authorName);
        }

        public ViewResult AddNewBook()
        {
            return View();
        }

        [HttpPost(Name ="AddNewBookRoute")]
        public ViewResult AddNewBook(BookModel bookModel)
        {
            return View();
        }


    }
}
