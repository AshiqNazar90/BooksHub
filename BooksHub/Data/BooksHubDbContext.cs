using BooksHub.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksHub.Data
{
    public class BooksHubDbContext:DbContext
    {
        public BooksHubDbContext(DbContextOptions<BooksHubDbContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
    }
}
