using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public interface IBookStoresDbContext
    {
        DbSet<Book> Books { get; set; }
    }
}