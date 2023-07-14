using BookStore.Data;
using BookStore.Data.Models;
using BookStore.Models;
using System.Linq;
using System.Data.SqlClient;

namespace BookStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoresDbContext context;

        public BookRepository(BookStoresDbContext context)
        {
            context = context;
        }

        public int AddBook(BookModel bookModel)
        {
            var book = new Book()
            {
                Id = bookModel.Id,
                Title = bookModel.Title,
                Author = bookModel.Author,
                Description = bookModel.Description,
                TotalPages = bookModel.TotalPages,
            };

            context.Books.Add(book);
            context.SaveChanges();
            return book.Id;

        }

        private BookModel ConvertBooktoBookModel(Book book)
        {
            var bookModel = new BookModel()
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                TotalPages = (int)book.TotalPages,
                Author = book.Author,
                Category = book.Category,
                Language = book.Language

            };
            return bookModel;
        }

        public List<BookModel> GetAllBooks()
        {
            var bookmodels = new List<BookModel>();
            var books = context.Books.ToList();
            foreach(var book in books)
            {
                var bookModel = ConvertBooktoBookModel(book);
                bookmodels.Add(bookModel);
            }
            return bookmodels;

        }

        public BookModel GetBook(int id)
        {
            return DataSource().Where(b => b.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(b => b.Title.Contains(title) && b.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title = "Science", Author="Yoyo", Description="About Science"},
                new BookModel(){Id=2, Title = "Astro", Author="Astro", Description="About Astronomy"},
                new BookModel(){Id=3, Title = "Maths", Author="YouKNowwho", Description="About you know who"},

            };
        }
    }
}
