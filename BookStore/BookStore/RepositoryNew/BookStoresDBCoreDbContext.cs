using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BookStore.RepositoryNew.Models;

namespace BookStore.RepositoryNew
{
    public partial class BookStoresDBCoreDbContext : DbContext
    {
        public BookStoresDBCoreDbContext()
        {
        }

        public BookStoresDBCoreDbContext(DbContextOptions<BookStoresDBCoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookModel> BookModels { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=default");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
