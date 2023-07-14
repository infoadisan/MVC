using BookStore.Data;
using BookStore.Data.Models;
using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookNewController : Controller
    {
        private readonly BookStoresDbContext context;

        //private readonly BookRepository bookRepository;

        public BookNewController(BookStoresDbContext context)
        {
            this.context = context;
        }


        public ViewResult AddNewBook(BookModel bookModel)
        {
            var book = new Book()
            {
                Id = bookModel.Id,
                Description = bookModel.Description,
                Author = bookModel.Author,
                Title = bookModel.Title,
                TotalPages = bookModel.TotalPages,
            };
            context.Add(book);
            context.SaveChanges();
            return View(bookModel);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
