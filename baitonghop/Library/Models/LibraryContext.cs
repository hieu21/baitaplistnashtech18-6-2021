using System;
using Microsoft.EntityFrameworkCore;
namespace Library.Models
{
    public class LibraryContext : DbContext
    {

        public LibraryContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    AuthorId = 1,
                    Name = "William",
                    BirthYear = new DateTime(1999,9,10)
                }
            );
            modelBuilder.Entity<Book>().HasData(
                new Book{
                    BookId = 1,
                    Title = "Game",
                    Price = 20,
                    PublishedYear = new DateTime(1998,5,20)
                }
            );
            modelBuilder.Entity<Client>().HasData(
                new Client {
                    ClientId = 1,
                    Name = "Hai"
                }
            );
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Client> Clients { get; set; }

    }
}