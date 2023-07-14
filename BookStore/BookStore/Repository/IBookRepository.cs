using BookStore.Models;

namespace BookStore.Repository
{
    public interface IBookRepository
    {
        int AddBook(BookModel bookModel);
        List<BookModel> GetAllBooks();
        BookModel GetBook(int id);
        List<BookModel> SearchBook(string title, string authorName);
    }
}