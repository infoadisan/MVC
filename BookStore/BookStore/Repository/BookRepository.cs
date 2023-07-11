using BookStore.Models;
using System.Linq;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
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
